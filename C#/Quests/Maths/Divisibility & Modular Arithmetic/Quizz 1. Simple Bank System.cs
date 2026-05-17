public class Bank
{   //Assited
    private long[] accounts;

    public Bank(long[] balance)
    {
        accounts = new long[balance.Length];

        for (int i = 0; i < balance.Length; i++)
        {
            accounts[i] = balance[i];
        }
    }

    private bool IsValidAccount(int account)
    {
        return account >= 1 && account <= accounts.Length;
    }

    public bool Transfer(int account1, int account2, long money)
    {
        if (!IsValidAccount(account1) || !IsValidAccount(account2))
            return false;

        int from = account1 - 1;
        int to = account2 - 1;

        if (accounts[from] < money)
            return false;

        accounts[from] -= money;
        accounts[to] += money;

        return true;
    }

    public bool Deposit(int account, long money)
    {
        if (!IsValidAccount(account))
            return false;

        accounts[account - 1] += money;
        return true;
    }

    public bool Withdraw(int account, long money)
    {
        if (!IsValidAccount(account))
            return false;

        int idx = account - 1;

        if (accounts[idx] < money)
            return false;

        accounts[idx] -= money;

        return true;
    }
}