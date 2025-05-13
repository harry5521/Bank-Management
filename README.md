# 🏦 Banking Management System – Windows Forms (C# + MySQL)

A feature-rich **Banking Management System** built using **C# (WinForms)** and **MySQL**, designed with **role-based authentication** and **RDBMS concepts**. This project includes powerful admin tools for managing user accounts, transactions, and funds — and is structured for real-world banking operations.

**Note:** I recently named this app to Bank Management but Before I was named it ATM_System when I was developing it so I used this name in many places like DB name or in code, so dont be confused OK.

---

## ✨ Key Features

### 🔐 Authentication System
- Separate **Login System** for `Admin` and `User`
- Password protection with role-based redirection
- Secure logout functionality for both roles

---

## 👤 User Mode
- Login via secure authentication
- Access a personalized **User Dashboard**
- Logout functionality

*(User module kept minimal for future development expansion)*

---

## 👑 Admin Mode

### 📁 Account Settings
- Manage all user accounts
- View, update, or delete user details

### 💸 Transactions
- Record user transactions (deposits, transfers, withdrawals)
- **Filter transactions** by Account ID for easy tracking

### 👥 Admin Management
- Add new admin accounts
- Delete existing admins
- Full admin role management

### 💵 Money Transfer
- Transfer money **from user accounts to bank account**
- Validate balance before transfers

### 💰 Deposit Amount
- Deposit funds into user accounts
- Balance updates in real-time

---

## 🛢️ Database

**Note:** MySQL script file is provided in **My_Sql Database Folder**
- Integrated with **MySQL Database**
- Designed with **Relational Database Concepts (RDBMS)**
- Proper **foreign key constraints** between tables for:
  - Users
  - Transactions
  - Admins
- Efficient SQL queries and structured schema

---

## 🔧 Tech Stack

| Layer        | Technology         |
|--------------|--------------------|
| Frontend UI  | C# Windows Forms   |
| Backend      | C#                 |
| Database     | MySQL              |
| Architecture | Role-Based Access + RDBMS |
