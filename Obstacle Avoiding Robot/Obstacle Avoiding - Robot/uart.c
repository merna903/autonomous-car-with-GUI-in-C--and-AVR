#include <avr/io.h>
#include <avr/interrupt.h>

#include "uart.h"


// Function to initialize USART
void UART_init(long USART_BAUDRATE)
{
	UCSR0B |= (1 << RXEN0) | (1 << TXEN0);	/* Turn on transmission and reception */
	UCSR0C = (1<<USBS0)|(3<<UCSZ00);		/* Use 8-bit char size */
	UBRR0L = BAUD_PRESCALE;					/* Load lower 8-bits of the baud rate */
	UBRR0H = (BAUD_PRESCALE >> 8);			/* Load upper 8-bits*/
}

// Function to transmit data
void UART_TxChar(char data)
{
	while (! (UCSR0A & (1<<UDRE0)));  /* Wait for empty transmit buffer */
	UDR0 = data ;
}

// Function to receive data
unsigned char UART_RxChar()
{
	while (!(UCSR0A & (1 << RXC)));		/* Wait till data is received */
	return(UDR0);						/* Return the byte */
}

void UART_SendString(char *str)					/* Send string of USART data function */
{
	int i=0;
	while (str[i]!=0)
	{
		UART_TxChar(str[i]);						/* Send each char of string till the NULL */
		i++;
	}
}