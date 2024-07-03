addmodal.cs
private async void addNewItemButtonModal_Click(object sender, EventArgs e)
{
    try
    {
        // Validate numerical values before parsing
        if (!decimal.TryParse(priceTextBox.Text, out decimal price))
        {
            MessageBox.Show("Please enter a valid decimal value for price.");
            return;
        }
        if (!int.TryParse(quantityTextBox.Text, out int quantity))
        {
            MessageBox.Show("Please enter a valid integer value for quantity.");
            return;
        }

        // Instantiate your Database class
        Database db = new Database();

        // Collect input values from text boxes
        string name = nametextBox.Text;
        string brand = brandTextBox.Text;
        string category = categoryTextBox.Text;
        string supplier = supplierTextBox.Text;
        string description = descriptionTextbox.Text;

        // Call the AddComputerPart method asynchronously
        bool success = await db.AddComputerPartAsync(name, brand, category, price, quantity, supplier, description);

        if (success)
        {
            MessageBox.Show("Item added successfully.");
            // Clear the text boxes
            nametextBox.Clear();
            brandTextBox.Clear();
            categoryTextBox.Clear();
            priceTextBox.Clear();
            quantityTextBox.Clear();
            supplierTextBox.Clear();
            descriptionTextbox.Clear();

            // Assuming this form is a modal dialog of the parent form that contains dataGridView1
            // Refresh dataGridView1 on the parent form
            var parentForm = this.Owner as MainForm; // Replace MainForm with the actual type of your parent form
            if (parentForm != null)
            {
                parentForm.RefreshDataGridView(); // Implement this method in your parent form to refresh dataGridView1
            }

            // Close the modal form
            this.Close();
        }
        else
        {
            MessageBox.Show("Failed to add the item.");
        }
    }
    catch (Exception ex)
    {
        MessageBox.Show($"An error occurred: {ex.Message}");
    }
}

//*******************



CREATE TABLE Barangays (
    BarangayID INT PRIMARY KEY IDENTITY,
    BarangayName NVARCHAR(255) NOT NULL
);

CREATE TABLE Residents (
    ResidentID INT PRIMARY KEY IDENTITY,
    BarangayID INT,
    Name NVARCHAR(255) NOT NULL,
    Age INT,
    Sex NVARCHAR(50),
    -- Other columns as needed
    CONSTRAINT FK_Residents_Barangays FOREIGN KEY (BarangayID) REFERENCES Barangays(BarangayID)
);

CREATE TABLE BarangayOfficials (
    OfficialID INT PRIMARY KEY IDENTITY,
    ResidentID INT,
    BarangayID INT,
    Role NVARCHAR(255) NOT NULL,
    CONSTRAINT FK_BarangayOfficials_Residents FOREIGN KEY (ResidentID) REFERENCES Residents(ResidentID),
    CONSTRAINT FK_BarangayOfficials_Barangays FOREIGN KEY (BarangayID) REFERENCES Barangays(BarangayID)
);

CREATE TABLE BarangayReports (
    ReportID INT PRIMARY KEY IDENTITY,
    BarangayID INT,
    ReportType NVARCHAR(255) NOT NULL,
    Status NVARCHAR(100),
    -- Other columns as needed
    CONSTRAINT FK_BarangayReports_Barangays FOREIGN KEY (BarangayID) REFERENCES Barangays(BarangayID)
);

CREATE TABLE BarangayEvents (
    EventID INT PRIMARY KEY IDENTITY,
    BarangayID INT,
    Location NVARCHAR(255) NOT NULL,
    EventDate DATETIME,
    Description NVARCHAR(MAX),
    CONSTRAINT FK_BarangayEvents_Barangays FOREIGN KEY (BarangayID) REFERENCES Barangays(BarangayID)
);

CREATE TABLE SystemUsers (
    UserID INT PRIMARY KEY IDENTITY,
    Username NVARCHAR(255) NOT NULL,
    PasswordHash NVARCHAR(255) NOT NULL,
    -- Include a BarangayID if you want to associate users with specific barangays
    -- BarangayID INT,
    -- CONSTRAINT FK_SystemUsers_Barangays FOREIGN KEY (BarangayID) REFERENCES Barangays(BarangayID),
    IsAdmin BIT
);