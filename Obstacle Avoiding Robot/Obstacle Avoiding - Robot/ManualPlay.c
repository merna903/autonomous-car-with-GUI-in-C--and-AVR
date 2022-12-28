/*
 * ManualPlay.c
 *
 * Created: 12/19/2022 8:26:53 PM
 *  Author: acer
 */ 
#include <avr/io.h>
#define  F_CPU 16000000UL
#include <util/delay.h>
#include "Ultarasonic/DIO/LIB/STD_TYPES.h"
#include "Ultarasonic/DIO/LIB/MATH.h"
#include "Ultarasonic/Ultrasonic_Interface.h"
#include "Ultarasonic/DIO/DIO_Interface.h"
#include "RC_Controling_interface.h"
#include "ManualPlay.h"
#include "ServoMotor.h"
#include "uart.h"
#include <avr/interrupt.h>

unsigned char movedata='0', temp='0';
void manual_paly()
{
	int distance;
	set_servo_angel(0);
	while(UDR0!='1')
	{
		distance =ultarasonic_distance()%1000;
		UART_TxChar(distance/100+48);
		distance %=100;
		UART_TxChar(distance/10+48);
		distance %=10;
		UART_TxChar(distance+48);
		movedata = UART_RxChar();
		if ( movedata != temp && movedata != '1' )
		{
			switch( movedata )
			{
				case '3': 
					forward();
					temp='3';
					break;
				case '4':
					backward();
					temp='4';
					break;
				case '5':
					right();
					_delay_ms(450);
					forward();
					temp='5';
					break;
				case '6':
					left();
					_delay_ms(450);
					forward();
					temp='6';
					break;
				case '7':
					stop();
					temp='7';
					break;
			}
		}
		
	}
}