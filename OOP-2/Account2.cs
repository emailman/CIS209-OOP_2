namespace OOP_2
{
    class Account2
    {
        public string Name { get; }
        public decimal Balance { get; private set; } 

        public Account2(string acctName, decimal acctBalance = 0)
        {
            Name = acctName;
            Balance = acctBalance;
        }

        public void Deposit(decimal amt)
        {
            Balance += amt;
        }

        public void Withdraw(decimal amt)
        {
            Balance -= amt;
        }

        override public string ToString()
        {
            return $"Account: {Name} / Balance = {Balance:C}";
        }
    }
}
