# SQL-CSharp-Project 

This is a **Movie Management System** developed using **C#** and **MySQL**. The system is designed to allow users to manage movies and access them through a user-friendly GUI interface. It provides both user and admin functionalities and ensures the security of data operations by implementing proper rules and conditions.

## Features

### **User Features:**
- **Login System**: Users can log in to the system with their credentials to access available movies.
- **View Movies**: Users can browse and view details about movies, such as title, description, genre, and release year.
- **Search & Filter**: Users can search and filter movies based on various criteria such as genre, release year, and title.
- **Watchlist**: Users can add movies to their personal watchlist for easy access.

### **Admin Features:**
- **Admin Login**: Only authorized admins can access the admin dashboard.
- **Manage Movies**: Admins can add, update, or delete movie records from the database.
- **User Management**: Admins can view, add, or delete user accounts.
- **View Analytics**: Admins can view basic statistics like total movies in the system and user activity.

### **Security Features:**
- **Password Encryption**: Passwords are securely encrypted before being stored in the database using **SHA-256** hashing.
- **SQL Injection Protection**: Prepared statements and parameterized queries are used to prevent SQL injection attacks.
- **Role-Based Access Control**: The system ensures only authorized users can perform certain actions (e.g., only admins can delete or add movies).
- **Session Management**: Secure login sessions are used to keep users and admins logged in.

### **MySQL Database Integration:**
- The project uses **MySQL** to store and manage data such as:
  - Movies (ID, title, genre, description, release year)
  - User information (ID, username, password hash, role)
  - Admin actions and system settings

### **GUI-Based User Interface:**
- The project provides a user-friendly graphical interface built using **Windows Forms** in C#.
- The interface allows users and admins to interact with the system in a seamless and intuitive way, providing buttons, text fields, and dialogs for easy navigation.

---

## Getting Started

### **Prerequisites**
Before running the project, make sure you have the following installed:

- **MySQL Server** - To store and manage the database.
- **Visual Studio** - To run and modify the C# project.
- **MySQL Connector for .NET** - To connect the C# application with MySQL.

### **Database Setup**

1. **Create a MySQL Database**:
   ```sql
   CREATE DATABASE MovieManagement;
   ```

2. **Create Tables**:
   The following SQL commands will create the necessary tables:

   ```sql
   CREATE TABLE Users (
       ID INT AUTO_INCREMENT PRIMARY KEY,
       Username VARCHAR(100) NOT NULL,
       PasswordHash VARCHAR(255) NOT NULL,
       Role ENUM('User', 'Admin') NOT NULL
   );

   CREATE TABLE Movies (
       ID INT AUTO_INCREMENT PRIMARY KEY,
       Title VARCHAR(255) NOT NULL,
       Genre VARCHAR(100),
       Description TEXT,
       ReleaseYear INT
   );
   ```

3. **Populate Sample Data** (Optional):
   ```sql
   INSERT INTO Users (Username, PasswordHash, Role) VALUES ('admin', SHA2('adminpassword', 256), 'Admin');
   INSERT INTO Movies (Title, Genre, Description, ReleaseYear) VALUES ('The Dark Knight', 'Action', 'Batman battles the Joker.', 2008);
   ```

### **Project Setup**

1. **Clone the Repository**:
   ```bash
   git clone https://github.com/yourusername/SQL-CSharp-Project.git
   ```

2. **Open the Project**:
   Open the project in **Visual Studio**.

3. **Configure Database Connection**:
   - Go to `App.config` (or `appsettings.json` if using .NET Core).
   - Modify the connection string to point to your MySQL server:
     ```xml
     <connectionStrings>
         <add name="MovieDB" connectionString="server=localhost;user=root;database=MovieManagement;port=3306;password=yourpassword;" providerName="MySql.Data.MySqlClient"/>
     </connectionStrings>
     ```

4. **Build and Run the Project**:
   Press **F5** or **Ctrl+F5** to build and run the project.

---

## Security Considerations

- **Password Security**: Passwords are hashed with **SHA-256** before storing them in the database, ensuring no plain-text passwords are saved.
- **SQL Injection Prevention**: All SQL queries use parameterized queries to prevent injection attacks.
- **Session Security**: Sessions are secured to ensure users are logged out after a period of inactivity or when they explicitly log out.
- **Role-Based Access**: Only admins have the ability to modify movie records or view sensitive data.

---

## Screenshots
- **Main PAGE**
![image](https://github.com/user-attachments/assets/02c3457e-636f-4ef3-8552-2dd81d402ad3)

- **Login Page**
- ![image](https://github.com/user-attachments/assets/c5fe4128-6f79-477a-aabc-6cd8dde1db61)

- **Admin Dashboard**
- ![image](https://github.com/user-attachments/assets/0d535e0c-c461-4fe3-a4ed-9405c32a6a69)


---

## Future Enhancements

- **API Integration**: Provide an API for accessing movie data remotely.
- **Advanced Search**: Implement more advanced search features such as filtering by ratings, release date, and more.
- **Improved Security**: Implement multi-factor authentication (MFA) for an added layer of security.

---

## License

This project is licensed under the MIT License – see the [LICENSE](LICENSE) file for details.
```

### **How to Use It:**
- Simply copy the above content and paste it into a **README.md** file in the root directory of your repository.
- Modify the placeholders (e.g., `yourusername`) as needed, and feel free to add or adjust sections according to your project's requirements.

Let me know if you'd like any further adjustments or help with anything else! 😊
