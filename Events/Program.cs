using System;
using EventExample;
					
namespace Training
{
  public class TestMyEvnt
  {
    public static void Main()
    {
      Account myAccount = new Account(1000);
      myAccount.TransactionMade += new TransactionHandler(SendNotification);
      myAccount.Credit(50);
      Console.WriteLine("Your Current Balance is : " + myAccount.BalanceAmount);

    }

    private static void SendNotification(object sender, TransactionEventArgs e)
    {
      Console.WriteLine($"Your Acount is {e.TranscationType} for ${e.TransactionAmount}");
    }
  }
}
namespace EventExample
{
  public delegate void TransactionHandler(object sender, TransactionEventArgs e);
  
  public class Account
  {
    public int BalanceAmount { get; set; }
    public Account(int balanceAmount)
    {
      BalanceAmount = balanceAmount;
    }

    public event TransactionHandler TransactionMade;

    public void Debit(int debitAmount)
    {
      if(debitAmount < BalanceAmount)
      {
        BalanceAmount -= debitAmount;
        TransactionEventArgs e = new TransactionEventArgs(debitAmount, "Debited");
        OnTransactionMade(e);
      }
    }

    protected virtual void OnTransactionMade(TransactionEventArgs e)
    {
      if(TransactionMade != null)
      {
        TransactionMade(this, e);
      }
    }

    public void Credit(int creditAmount)
    {
      BalanceAmount += creditAmount;
        TransactionEventArgs e = new TransactionEventArgs(creditAmount, "credited");
        OnTransactionMade(e);
    }
  }

  public class TransactionEventArgs : EventArgs
  {
    public int TransactionAmount { get; }
    public string TranscationType { get; }

    public TransactionEventArgs(int transactionAmount, string transcationType)
    {
      TransactionAmount = transactionAmount;
      TranscationType = transcationType;
    }
  }
}
