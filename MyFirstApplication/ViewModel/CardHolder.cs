using System;

public class CardHolder
{

    string userName;
    string userPassword;
    int CardNumber;
    int pin;
    string fName;
    string lName;
    double balance;
    double savings;


    public CardHolder(string userName, string userPassword, int CardNumber, int pin, string fName, string lName, double balance, double savings)
    {
        this.userName = userName;
        this.userPassword = userPassword;
        this.CardNumber = CardNumber;
        this.pin = pin;
        this.fName = fName;
        this.lName = lName;
        this.balance = balance;
        this.savings = savings;
    }

    public string getUserName()
    {
        return userName;
    }

    public string getPassword()
    {
        return userPassword;
    }

    public int getCardNumber()
    {
        return this.CardNumber;
    }

    public int getPin()
    {
        return this.pin;
    }

    public String getFName()
    {
        return this.fName;
    }

    public String getLName()
    {
        return this.lName;
    }

    public double getBalance()
    {
        return this.balance;
    }

    public double getSavings()
    {
        return this.savings;
    }

    public void setUserName(String userName)
    {
        this.userName = userName;
    }

    public void setUserPassword(String userPassword)
    {
        this.userPassword = userPassword;
    }

    public void setCardNumber(int CardNumber)
    {
        this.CardNumber = CardNumber;
    }

    public void setPin(int pin)
    {
        this.pin = pin;
    }

    public void setLName(string lName)
    {
        this.lName = lName;
    }

    public void setFName(string fName)
    {
        this.fName = fName;
    }

    public void setBalance(double balance)
    {
        this.balance = balance;
    }

    public void setSavings(double savings)
    {
        this.savings = savings;
    }

}