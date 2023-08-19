[TestFixture]
public class FormAddPatientTests
{
  private FormAddPatient form;
  
  [SetUp]
  public void Setup() 
  {
    form = new FormAddPatient();
  }

  [Test]
  public void ValidateRequiredFields()
  {
    // Act
    form.BtnAddPatient_Click(null, null);
    
    // Assert
    Assert.IsNotEmpty(form.errorProvider1.GetError(form.TbFirstName));
    Assert.IsNotEmpty(form.errorProvider1.GetError(form.TbMiddleName));
    // Assert all required fields

  }

  [Test]
  public void ValidateEmail()
  {
    // Arrange
    form.TbEmail.Text = "invalidEmail";
    
    // Act
    form.BtnAddPatient_Click(null, null);  
    
    // Assert
    Assert.IsNotEmpty(form.errorProvider1.GetError(form.TbEmail));

  }

  [Test]
  public void TestValidInput()
  {
    // Arrange - populate valid data

    // Act
    form.BtnAddPatient_Click(null, null);

    // Assert 
    Assert.IsEmpty(form.errorProvider1.GetError(form.TbFirstName));
    // Assert no errors

  }

}


[TestFixture]
public class FormPatientInfoTests
{

  [Test]
  public void TestDeletePatient()
  {
    var mockPatient = new Patient(){ ID = "1"};

    var form = new FormPatientInfo(mockPatient);

    form.BtnDeleteRecord_Click(null, null);

    Assert.IsTrue(mockPatient.IsDeleted);

  }
  
}