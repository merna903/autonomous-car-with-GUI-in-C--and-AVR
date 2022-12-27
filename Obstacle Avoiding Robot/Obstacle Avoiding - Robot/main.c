#include <avr/io.h>
#include <avr/delay.h>
#include <math.h>
#include "Ultarasonic/DIO/LIB/STD_TYPES.h"
#include "Ultarasonic/DIO/LIB/MATH.h"
#include "Ultarasonic/DIO/DIO_Interface.h"
#include "Ultarasonic/Ultrasonic_Interface.h"
#include "ServoMotor.h"
#include "RC_Controling_interface.h"
#include "Q_learn.h"
#include "uart.h"
#include "ManualPlay.h"
#define  F_CPU 16000000UL
#include <util/delay.h>
int fristTime ;
int main(void)
{
	fristTime =0;
	//Set the Arduino led as output
	DIO_SetPinDirection(PORT1,5,OUTPUT);
	//Set the motor directions pins as output
	DIO_SetPinDirection(PORT3,2,OUTPUT);
	DIO_SetPinDirection(PORT3,3,OUTPUT);
	DIO_SetPinDirection(PORT3,4,OUTPUT);
	DIO_SetPinDirection(PORT3,5,OUTPUT);
	//Set Trigger pin of the ultrasonic as output	
	DIO_SetPinDirection(PORT3,PIN7,OUTPUT);
	// Configuration + center position
	set_servo_angel(0); 
	_delay_ms(1000);
	// Config the motor speed 
	config_RC_Driver();
	UART_init(9600);
	
	void auto_play(){
		//Clear the Arduino led
		DIO_SetPinValue(PORT1,5,0);
		Train();
		//Set the Arduino led
		DIO_SetPinValue(PORT1,5,1);
		Test();
	}
	
	unsigned char data = 0;
    while (1)
    {	
		if (fristTime==0)	
		{
			data = UART_RxChar();
			fristTime = 1;
		}
    	else data = UDR0;
		if( data == '1' )
		{
			auto_play();
		}
		else if ( data == '2' )
		{
			manual_paly();
		} 
	}
}


 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 