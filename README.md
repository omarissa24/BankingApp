# Bank Management Application

## Introduction

The Bank Management Application is a secure and user-friendly Windows Forms application designed for managing personal banking transactions. It provides a convenient way for users to perform essential banking operations like withdrawals, deposits, viewing account balances, and reviewing mini statements.

## Features

- **Secure Login:** Users can access their accounts using a username and PIN. The application ensures security by hashing the PIN with SHA-256 encryption, providing an additional layer of security against unauthorized access.

- **Withdrawal:** Users can easily withdraw money from their account, specifying the amount they wish to withdraw.

- **Deposit:** Depositing money into the account is made simple and intuitive. Users can enter the amount they wish to deposit, and the application updates the account balance accordingly.

- **View Balance:** Users can check their current account balance at any time, providing them with up-to-date information about their financial status.

- **Mini Statement:** The application offers a mini statement feature that allows users to view their recent transactions, helping them keep track of their spending and deposits.

## How to Use

1. **Logging In:** Start by launching the application and entering your username and PIN at the login screen. Remember, your PIN is securely hashed for your protection. (You might want to create a user first in the signup form)

2. **Navigating the Application:** Once logged in, you'll be presented with the main interface, where you can choose from the available banking operations: Withdraw, Deposit, View Balance, or Mini Statement.

3. **Performing Transactions:** Select the desired operation and follow the on-screen instructions to complete your transaction. For withdrawals and deposits, you'll need to enter the amount.

4. **Viewing Account Balance and Mini Statement:** To check your balance or view a mini statement, simply select the respective option, and your information will be displayed immediately.

## Security

- The application employs SHA-256 hashing for PINs, ensuring that your personal information remains encrypted and secure.

## Installation / Setup

To install the Bank Management Application on your Windows system, follow these steps:

1. Install MySql.Data from your Nuget Package Manager. (Right click on dependencies -> Click on manage Nuget Packages -> Browse and Install Required Packages.)
2. Add your DB_SERVER, DB_DATABASE, DB_UID, DB_PASSWORD in your system environement variables to connect to your desired database.
