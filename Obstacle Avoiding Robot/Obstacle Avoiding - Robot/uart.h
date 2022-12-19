#ifndef _UART_H_
#define _UART_H_

#define BAUD_PRESCALE (((F_CPU / (USART_BAUDRATE * 16UL))) - 1)

extern void 		 UART_Init(long USART_BAUDRATE);
extern void 		 UART_TxChar(char ch);
extern unsigned char UART_RxChar();

#endif
