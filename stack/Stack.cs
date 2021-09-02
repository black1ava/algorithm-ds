using System;

namespace Stack {
	public class Stack<T>{
		private int top;
		private int size;
		private T[] stack;
		public Stack(int size){
			this.top = -1;
			this.size = size;
			stack = new T[size];
		}

		public bool isFull(){
			return this.top == this.size - 1;
		}

		public bool isEmpty(){
			return this.top == -1;
		}

		public void push(T n){
			if(!this.isFull()){
				this.top++;
				this.stack[this.top] = n;
				return;
			}

			Console.WriteLine("Stack is full");
		}

		public T pop(){
			if(!this.isEmpty()){
				T n = this.stack[this.top];
				this.top--;
				return n;
			}

			return (T)(object)Int32.MinValue;
		}

		public void printStack(){
			if(this.isEmpty()){
				Console.WriteLine("Queue is Empty");
				return;
			}

			for(int i = 0; i <= this.top; i++){
				Console.Write("{0} ", this.stack[i]);
			}

			Console.WriteLine("");
		}
	}
	public class MainClass{
		public static void Main(){
			Stack<int> stack = new Stack<int>(10);

			int number = 25;

			while(number > 0){
				stack.push(number % 2);
				number /= 2;
			}
			
			while(!stack.isEmpty()){
				Console.Write(stack.pop());
			}
		}
	}
}