using System;

namespace Queue {
	public class Queue<T> {
		private int size;
		private int front;
		private int rear;
		private T[] queue;
		public Queue(int size){
			this.size = size;
			this.front = this.rear = -1;
			this.queue = new T[size];
		}

		public bool isFull(){
			return this.rear == this.size - 1;
		}
		public bool isEmpty(){
			return this.front == -1;
		}

		public void enqueue(T n){
			if(this.isFull()){
				Console.WriteLine("Queue is full");
				return;
			}

			if(this.front == -1){
				this.front = this.rear = 0;
				this.queue[0] = n;
				return;
			}

			this.rear++;
			this.queue[this.rear] = n;
		}

		public T dequeue(){
			if(this.isEmpty()){
				return (T)(object)Int32.MinValue;
			}

			if(this.front == this.rear){
				this.front = this.rear = -1;
			}

			T n = this.queue[this.front];
			this.front++;
			return n;
		}

		public void printQueue(){
			if(this.isEmpty()){
				Console.WriteLine("Queue is empty");
				return;
			}

			for(int i = this.front; i <= this.rear; i++){
				Console.Write("{0} ", this.queue[i]);
			}

			Console.WriteLine();
		}
	}

	public class MainClass{
		public static void Main(string[] args){
			Queue<int> queue= new Queue<int>(10);
			queue.enqueue(1);
			queue.enqueue(2);
			queue.enqueue(3);
			queue.dequeue();
			queue.printQueue();
		}
	}
}