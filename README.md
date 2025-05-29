# Inventory Management System

## Project Description

This is a desktop-based Inventory Management System built with Visual Basic .NET. The application provides a comprehensive solution for businesses to track inventory, manage products, suppliers, customers, and handle both purchase and sales transactions.

## Technologies Used

- **Framework**: .NET Framework 4.5
- **Language**: Visual Basic (VB.NET)
- **Development Environment**: Visual Studio 2012
- **Project Type**: Windows Forms Application
- **Database**: Microsoft Access Database (Invent_Mgt_old.mdb)

## Features

- **User Authentication**: Secure login system to control access to the application
- **Dashboard**: Main interface providing overview of inventory status
- **Product Management**: Add, edit, and manage product inventory
- **Customer Management**: Track customer information and purchase history
- **Supplier Management**: Manage supplier details and purchase records
- **Stock Management**: Monitor current stock levels
- **Transaction Processing**:

  - Create new transactions
  - Track purchase records
  - Record sales transactions
  - View transaction history

## System Requirements

- Windows 7 or later
- .NET Framework 4.5 or higher
- Minimum 2GB RAM
- 100MB available disk space

## Installation

1. Clone this repository or download the source code
2. Open the solution file (`InventoryMgt.sln`) in Visual Studio 2012 or later
3. Build the solution
4. Make sure the database file (`Invent_Mgt_old.mdb`) is in the correct location
5. Run the application

## Configuration

The application can be built for both x86 and x64 platforms. Configuration settings can be modified in:

- `App.config`
- `Settings.settings`

## Project Structure

- **Main Forms**:
  - Login: User authentication screen
  - Main_Window: Primary dashboard interface
  - Customers: Customer management
  - Suppliers: Supplier management
  - prod: Product catalog and management
  - stocks: Inventory levels and stock tracking
  - New_Transaction: Transaction creation interface
  - Purchase_Rec: Purchase history and record keeping
  - Selling_Rec: Sales history and record keeping
  - Transactions: Complete transaction log view

## Usage

1. Launch the application
2. Log in with valid credentials
3. Navigate through the main window to access different modules
4. Manage inventory, customers, suppliers, and transactions as needed

## Future Enhancements

- Export functionality for reports
- Barcode scanning integration
- Advanced analytics and reporting
- Multi-user support with different permission levels
- Cloud synchronization
