# My Console App

A brief description of your console application. Explain what it does and its main purpose.

## 🚀 Getting Started

These instructions will get you a copy of the project up and running on your local machine for development and testing purposes.

### Prerequisites

You'll need the following installed:

* [.NET SDK](https://dotnet.microsoft.com/download) (Specify the version you're using, e.g., 8.0)
* [Mailpit](https://github.com/axllent/mailpit) (A local SMTP server for testing email functionality)

### Installation

1.  **Clone the repository:**
    ```bash
    git clone [https://github.com/your-username/your-repository-name.git](https://github.com/your-username/your-repository-name.git)
    cd your-repository-name
    ```

2.  **Restore dependencies:**
    ```bash
    dotnet restore
    ```

---

## ⚙️ Running the Application

### Development

To run the application in development mode:

1.  **Start Mailpit:**
    Ensure Mailpit is running on your machine. You can typically start it from your terminal.

2.  **Run the application:**
    ```bash
    dotnet run
    ```
    This will execute the main program. Any emails sent by the application will be captured by Mailpit. You can view them by navigating to the Mailpit web interface, usually at `http://localhost:8025`.

### Testing

To run the unit and integration tests:

1.  **Start Mailpit:**
    Make sure Mailpit is running before you run the tests.

2.  **Run the tests:**
    ```bash
    dotnet test
    ```
    This command will run all tests in your project, including any that interact with the local Mailpit server.

---

## 📧 Email Configuration

This application uses a local Mailpit server for all email-related testing. The SMTP settings are configured in the `appsettings.json` or a similar configuration file.

**Example `appsettings.json` snippet:**

```json
{
  "SmtpSettings": {
    "Host": "localhost",
    "Port": 1025,
    "Username": "",
    "Password": ""
  }
}
