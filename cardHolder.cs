using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public class cardHolder
    {
        // дефиниране на полета
        string cardNum;
        int pin;
        string firstName;
        string lastName;
        decimal balance;

        // конструктор с параметри
        public cardHolder(string cardNum, int pin, string firstName, string lastName, decimal balance)
        {
            this.cardNum = cardNum;
            this.pin = pin;
            this.firstName = firstName;
            this.lastName = lastName;
            this.balance = balance;
        }

        // конструктор без параметри
        public cardHolder()
        {
            this.cardNum = null;
            this.pin = 0;
            this.firstName = null;
            this.lastName = null;
            this.balance = 0;
        }

        // Инициализиране на свойства
        public string getNum() { return cardNum; }
        public int getPin() { return pin; }
        public string getFirstName() { return firstName; }
        public string getLastName() { return lastName; }
        public decimal getBalance() { return balance; }

        // Инициализиране на методи
        public void setNum(string newCardNum) { cardNum = newCardNum; }
        public void setPin(int newPin) { pin = newPin; }
        public void setFirstName(string newFirstName) { firstName = newFirstName; }
        public void setLastName(string newLastName) { lastName = newLastName; }
        public void setBalance(decimal newBalance) { balance = newBalance; } 

    }
}
