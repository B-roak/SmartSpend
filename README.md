## SmartSpend
*A simple way to plan your home budget 📝*

**SmartSpend** is a desktop application for managing personal finances, built with **WPF (.NET)**.  
It helps users keep track of expenses, plan budgets, and visualize financial data.

# About Application 
SmartSpend is a simple application for managing your budget. You will find it transparent and user-friendly. It allows you to add, save and delete your current expenses from a list. It displays it on a chart too. Now you can see all your expenses and manage them in one place!

# Instalation
You need to download this repository, and have already installed newest version of VisualStudio. You can operate on application only on Windows operating system (WPF). After downloading, open SmartSpend.sln file and restore nugget packages (`Build > Restore NuGet Packages`). Then press F5 or start icon at top of the shown window. 

# Features
- Add, save and delete expenses
- Categorize expenses
- Data visualization (charts, tables)
- Export data
- Nuggets (LiveCharts, SQLite)

# Database 
This project uses SQLite database, because the amount of data doesn't require bigger and more complex database. However it could be changed at any moment in DataManager class, enabling you to have your own way of saving data.
  
# Usage
On the main menu, click the "Add expenses" button. 
![alt text](https://github.com/B-roak/SmartSpend/blob/main/Screens/menu.png "Main menu of SmartSpend application")
<br>This will show you a new window, where you can choose your expense category, type and input the cost.
![alt text](https://github.com/B-roak/SmartSpend/blob/main/Screens/addexpense.png "Add expenses menu of SmartSpend application")
<br>After adding, the pie chart on the main menu will show your added expenses, color coded to differentiate each category. Then, you can either add new expenses, or delete existing ones.
![alt text](https://github.com/B-roak/SmartSpend/blob/main/Screens/list.png "Drop down list in SmartSpend application")


# Technologies used
- C#
- WPF (.NET 8.0)
- XAML
- NuGet (pie chart, SQLlite)

# Project Structure

```text
SmartSpend-main/
├── SmartSpend.sln
├── SmartSpend/
│   ├── App.xaml
│   ├── App.xaml.cs
│   ├── MainWindow.xaml
│   ├── MainWindow.xaml.cs
│   ├── SmartSpend.csproj
│   └── ...
└── README.md
```
