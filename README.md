# Contact Manager

Welcome to the Contact Manager app! This console application allows you to manage a list of contacts. You can add, remove, and view contacts using a simple menu-driven interface.

## Table of Contents

- [Features](#features)
- [Installation](#installation)
- [Usage](#usage)
- [Contact Methods](#contact-methods)
- [Helper Methods](#helper-methods)
- [Unit Tests](#unit-tests)

## Features

- **Add Contact**: Add a new contact to your list.
- **Remove Contact**: Remove an existing contact from your list.
- **View All Contacts**: View all contacts in your list.

## Installation

1. **Clone the Repository**:
   ```bash
   git clone https://github.com/Loiy2002-SW/Contact-Manager.git
   cd Contacts-Manager
2. **Clone the Repository**:
   ```bash
   dotnet build
3. **Clone the Repository**:
   ```bash
   dotnet run --project ContactManager

## Usage

1. Starting the Application

	Run the application using the `dotnet run` command. You will be presented with a menu to choose an operation:

	1. `1 = Add Contact`
	2. `2 = Remove Contact`
	3. `3 = View Contacts`


2. Adding a Contact

	1. Choose option `1`.
	2. Enter the contact name when prompted. Ensure the name has a minimum length of 2 and does not contain numbers.

3. Removing a Contact

	1. Choose option `2`.
	2. Enter the contact name you want to remove.

4. Viewing All Contacts

	1. Choose option `3`.
	2. The application will display the list of all contacts.

## Contact Methods

- **AddContact(string contact)**:
  Adds a new contact to the list if it doesn't already exist.

- **RemoveContact(string contact)**:
  Removes an existing contact from the list.

- **ViewAllContacts()**:
  Returns the list of all contacts.

## Helper Methods

- **ContactsManager()**:
  Displays the welcome message and the main menu.

- **ChooseOperation()**:
  Handles the user input for choosing an operation and calls the corresponding method.

- **AskIfTheUserWantToDoAnotherOperation()**:
  Asks the user if they want to perform another operation and handles the response.

- **AskForContactNameToBeAdded()**:
  Prompts the user to enter a valid contact name for adding.

- **AskForContactNameToBeRemoved()**:
  Prompts the user to enter a valid contact name for removing.

## Unit Tests

Ensure that you have `xUnit` installed and set up for testing. Below are the tests available:

- **AddContact_ValidContact_AddsSuccessfully**:
  Tests if a valid contact is added successfully.

- **AddContact_ExistingContact_ThrowsException**:
  Tests if adding a duplicate contact throws an exception.

- **RemoveContact_ExistingContact_RemovesSuccessfully**:
  Tests if an existing contact is removed successfully.

- **ViewAllContacts_ReturnsAllContacts**:
  Tests if all contacts are returned correctly.

## Contributing

Contributions are welcome! Please fork the repository and create a pull request with your changes.
