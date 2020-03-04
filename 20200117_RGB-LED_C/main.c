#include <stdio.h>
#include "USART.h"
#include <avr/interrupt.h>
#include <avr/io.h> 

void main(void)
{
	cli();

	DDRB |= (1 << PB5) | (1 << PB6) | (1 >> PB7);

	TCCR1B |= (1 << CS11) | (1 << WGM12);
	TCCR1A |= (1<<WGM10) | (1 << COM1A1) | (1 << COM1B1) | (1 << COM1C1);

	int red, green, blue;

	USARTInit(0, 9600, 1, 0, 1, 0);

	sei();

	do
	{

		if (scanf("%d;%d;%d;", &red, &green, &blue) == 3)
		{
			printf("%d;%d;%d;\n", red, green, blue);
			OCR1A = red;
			OCR1B = green;
			OCR1C = blue;
		}
		
	} while (1);
}