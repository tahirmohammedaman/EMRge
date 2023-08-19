[TestFixture]
public class FormLaboratoryTests
{
  private FormLaboratory formLab;
  
  [SetUp]
  public void Setup()
  {
    formLab = new FormLaboratory(); 
  }

  [Test]
  public void TestFormLoad()
  {
    // Arrange
    var mockLabRecords = new List<LaboratoryTestRecord>();
    
    // Add mock records
    mockLabRecords.Add(new LaboratoryTestRecord(){ ID = "1"});
    mockLabRecords.Add(new LaboratoryTestRecord(){ ID = "2"});

    LaboratoryTestRecord.GetLaboratoryTestRecords = () => mockLabRecords;

    // Act 
    formLab.FormLaboratory_Load(null, null);

    // Assert
    Assert.AreEqual(2, formLab.DGVLaboratoryQueue.Rows.Count); 
    Assert.AreEqual("1", formLab.DGVLaboratoryQueue.Rows[0].Cells["ID"].Value);
    Assert.AreEqual("2", formLab.DGVLaboratoryQueue.Rows[1].Cells["ID"].Value);

  }

  [Test]
  public void TestSelectLabRecord()
  {
    // Arrange
    var mockLabRecord = new LaboratoryTestRecord(){
      ID = "1",
      ExaminationRecordID = "ER1",
      DateAndTime = DateTime.Now,
      PatientID = "P1",
      TestType = "Test 1"
    };

    formLab.DGVLaboratoryQueue.DataSource = new List<LaboratoryTestRecord>(){mockLabRecord};

    // Act
    formLab.DGVLaboratoryQueue_DoubleClick(null, null);

    // Assert
    Assert.AreEqual("1", formLab.selectedLabTest.ID);
    Assert.AreEqual("ER1", formLab.LblExaminationID.Text);
    Assert.AreEqual(mockLabRecord.DateAndTime.ToString(), formLab.LblDate.Text); 
    Assert.AreEqual("Test 1", formLab.LblTestType.Text);
    Assert.AreEqual("P1", formLab.LblPatientID.Text);

  }

  [Test]
  public void TestSubmitResults()
  {
    // Arrange
    var mockLabRecord = new LaboratoryTestRecord(){
      ID = "1", 
      ExaminationRecordID = "ER1"
    };

    formLab.selectedLabTest = mockLabRecord;
    formLab.TbResults.Text = "Positive";

    // Act
    formLab.BtnSubmitResults_Click(null, null);

    // Assert
    Assert.AreEqual("Positive", mockLabRecord.Result);
    Assert.IsTrue(mockLabRecord.IsRemovedFromQueue);

  }

}