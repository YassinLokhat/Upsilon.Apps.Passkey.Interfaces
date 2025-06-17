# Upsilon.Apps.Passkey.Interfaces

------------
**Overview**
------------

This C# Library serves as the core interface of a password manager, enabling secure local storage and management of user credentials with advanced multi-layer encryption and security features.

------------
**Features**
------------

*   **Credentials Storage**: Securely store accounts and services locally.
*   **Advanced Multi-Layer Encryption**: Implement robust, multi-stage data protection using AES and RSA algorithms.
*   **Password Generation**: Generate strong, unique passwords.
*   **Comprehensive Logging**: Detailed event tracking with secure, encrypted logs.
*   **Intelligent Warning System**: Proactive security alerts and notifications.
*   **Autosave**: Automatic update preservation.

------------
**Security Architecture**
------------

### Encryption Strategy
*   **Data Encryption**: 
    - AES encryption for database and autosave files
    - Multi-layer encryption using an ordered set of passkeys
    - Each passkey encrypts data in an "onion" style, adding complexity to decryption

*   **Log File Security**: 
    - RSA encryption with 2048-bit key
    - Public key allows log entry addition
    - Private key required for log review

### Multi-Passkey Authentication
*   Enhanced security through sequential passkey verification
*   Prevents brute-force attacks by removing predictability
*   Login process requires correct entry of all passkeys in precise order

**Key Security Benefits**:
*   No intermediate decryption hints
*   Increased complexity for potential attackers
*   Flexible, user-defined passkey sequences

------------
**Warning and Alert System**
------------

Comprehensive warning mechanisms include:

*   Password Expiration Reminders
*   Duplicate Password Detection
*   Password Leak Alerts
*   Unauthorized Access Attempt Notifications and Login Failure Tracking
*   Unsaved Update Highlighting
*   Recent Password Change Alerts

----------
**Technical Specifications**
----------

*   **Platform**: Multi-platform (Windows, Linux)
*   **Framework**: .NET 8
*   **Dependencies**: Native .NET libraries only

----------
**Models**
----------

## Class diagram
![ClassDiagram](https://github.com/user-attachments/assets/7c17f2a2-c62b-4a9a-808f-c0f471c23609)

-------------------
**Getting Started**
-------------------

1.  Clone the repository: `git clone https://github.com/YassinLokhat/Upsilon.Apps.Passkey.Interfaces.git`
2.  Build the solution: `dotnet build`
3.  Run the API: `dotnet run`

----------------
**Contributing**
----------------

Contributions are welcome! Please submit a pull request with your changes.

-----------
**License**
-----------

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.
