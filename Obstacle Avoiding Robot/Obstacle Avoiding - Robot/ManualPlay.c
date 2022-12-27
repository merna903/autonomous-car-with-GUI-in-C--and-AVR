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
unsigned char movedata='0', temp='0';
void manual_paly()
{
	set_servo_angel(0);
	while(UDR0!='1')
	{
		movedata = UDR0;
		if ( movedata != temp && movedata != '1' )
		{
			forward();
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
					_delay_ms(100);
					stop();
					temp='5';
					break;
				case '6':
					left();
					_delay_ms(100);
					stop();
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