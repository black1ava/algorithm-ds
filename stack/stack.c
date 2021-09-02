#include<stdio.h>
#include<stdlib.h>
#include<stdbool.h>

typedef struct Stack{
	int top;
	int size;
	int *node;
} Stack;

Stack *stack_new(int size){
	Stack *stack = (Stack *)malloc(sizeof(Stack));

	stack->size = size;
	stack->top = -1;
	stack->node = (int *)malloc(size * sizeof(int));

	return stack;
}

bool isFull(Stack *stack){
	return stack->top == stack->size  - 1;
}

bool isEmpty(Stack *stack){
	return stack->top == -1;
}

void stack_push(Stack *stack, int n){
	if(isFull(stack)){
		printf("Stack is full\n");
		return;
	}

	stack->top++;
	stack->node[stack->top] = n;
}

void stack_pop(Stack *stack){
	if(isEmpty(stack)){
		printf("Stack is empty\n");
		return;
	}

	stack->top--;
}

void s_print(Stack *stack){
	if(isEmpty(stack)){
		printf("Stack is empty\n");
		return;
	}

	for(int i = 0; i <= stack->top; i++){
		printf("%d ", stack->node[i]);
	}

	printf("\n");
}

int main(){
	Stack *stack = stack_new(10);
	for(int i = 1; i <= 10; i++){
		stack_push(stack, i);
	}
	stack_pop(stack);
	s_print(stack);
	return 0;
}