# Name Sorter

The Name Sorter is a .NET Core Console Application designed to sort names from a given input file. The names are sorted by their last names; if two last names are identical, given names are used as a tie-breaker.

## Getting Started

### Prerequisites

1. Ensure you have the [.NET Core SDK](https://dotnet.microsoft.com/download) installed.
2. Clone this repository:
   ```bash
   git clone https://github.com/your-username/NameSorter.git
   ```

### Building and Running the Project

1. Navigate to the project's root directory:
   ```bash
   cd NameSorter
   ```

2. Build the project:
   ```bash
   dotnet build
   ```

3. Run the project by providing an input file path as an argument:
   ```bash
   dotnet run -- path/to/input.txt
   ```

   This will produce an output file `sorted-names-list.txt` containing the sorted names and also display the sorted list in the console.

## Design & Implementation

The solution emphasizes the SOLID principles to ensure maintainability, scalability, and testability:

- **Single Responsibility Principle**
- **Open/Closed Principle**
- **Liskov Substitution Principle**
- **Interface Segregation Principle**
- **Dependency Inversion Principle**

## Testing

Unit tests are available in the `NameSorterTests` project and use the `MSTest` framework. To run the tests:

1. Navigate to the tests directory:
   ```bash
   cd NameSorterTests
   ```

2. Run the tests:
   ```bash
   dotnet test
   ```
