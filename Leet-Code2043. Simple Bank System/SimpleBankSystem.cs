public class Bank {
    private long[] balances;

    public Bank(long[] balance) {
        balances = balance;
    }
    
    public bool IsValidAccount(int account){
        return account > 0 && account <= balances.Length;
    }

    public bool Transfer(int account1, int account2, long money) {
         if(!IsValidAccount(account1) || !IsValidAccount(account2))
            {
                return false;
            }

        if(balances[account1-1] < money){
            return false;
        }
        else{
            balances[account1-1] -= money;
            balances[account2-1] += money;
            return true;
        }
    }
    
    public bool Deposit(int account, long money) {
        if (!IsValidAccount(account))
        {
            return false; 
        }
        balances[account-1] += money;
        return true;
    }
    
    public bool Withdraw(int account, long money) {
        if (!IsValidAccount(account))
        {
            return false; 
        }
        if(balances[account-1] < money){
            return false;
        }
        balances[account-1] -= money;
        return true;
    }
}

/**
 * Your Bank object will be instantiated and called as such:
 * Bank obj = new Bank(balance);
 * bool param_1 = obj.Transfer(account1,account2,money);
 * bool param_2 = obj.Deposit(account,money);
 * bool param_3 = obj.Withdraw(account,money);
 */
