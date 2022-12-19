/*
 * ManualPlay.c
 *
 * Created: 12/19/2022 8:26:53 PM
 *  Author: acer
 */ 
#include <avr/delay.h>
#include "Ultarasonic/DIO/LIB/STD_TYPES.h"
#include "Ultarasonic/DIO/LIB/MATH.h"
#include "Ultarasonic/DIO/DIO_Interface.h"
#include "RC_Controling_interface.h"
#include "ManualPlay.h"
#include "ServoMotor.h"
#include <avr/io.h>
#include <avr/delay.h>
#include <avr/interrupt.h>
#include <avr/io.h>
unsigned char data='z', temp='z';
int distance,;
void manual_paly()
{
	set_servo_angel(0);
	while(true)
	{
		data = UART_RxChar();
		if (data!=temp)
		{
			switch(data)
			{
				case 'f': 
					forward();
					temp='f';
					break;
				case 'b':
					backward();
					temp='b';
					break;
				case 'r':
					right();
					temp='r';
					break;
				case 'l':
					left();
					temp='l';
					break;
				case 's':
					stop();
					temp='s';
					break;
			}
		}
		distance =ultarasonic_distance();
		if(distance<40)
		{
			UART_TxChar('1');
		}
		else
		{
			UART_TxChar('2');
		}
		UART_TxChar(distance/100);
		distance %=100;
		UART_TxChar(distance/10);
		distance %= 10;
		UART_TxChar(distance);
		_delay_ms(100);
	}
}