# Direct Field Access in C#

This repository demonstrates a common C# coding error: directly accessing a private field instead of using its corresponding property. While seemingly straightforward, this practice can introduce several problems, including:

* **Breaking encapsulation:** Direct field access bypasses any validation or logic implemented in the property's setter, potentially leading to invalid data states. 
* **Maintenance challenges:** Modifying the internal representation of the field (e.g., adding validation or logic) necessitates changes in all places where the field is directly accessed. 
* **Reduced code readability:** Direct field access makes the code harder to understand and maintain, as it hides the intended behavior and control mechanisms.

The `bug.cs` file contains the code with the error, and `bugSolution.cs` provides the corrected version.