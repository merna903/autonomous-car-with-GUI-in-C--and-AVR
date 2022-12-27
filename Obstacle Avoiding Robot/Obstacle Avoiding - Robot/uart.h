#ifndef _UART_H_
#define _UART_H_
#define  F_CPU 16000000UL


extern void 		 UART_init(long USART_BAUDRATE);
extern void 		 UART_TxChar(char ch);
extern unsigned char UART_RxChar();

#endif
