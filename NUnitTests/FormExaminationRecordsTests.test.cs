[Test]
public void TestLoadExaminationRecords_Empty() 
{
  // Arrange
  FormExamination form = new FormExamination(); 
  
  // Act
  form.FormExamination_Load(null, null);

  // Assert
  Assert.IsEmpty(form.DGVExaminationQueue.DataSource); 
}

[Test]
public void TestCompleteExamination_NullExam()
{
  // Arrange
  FormExamination form = new FormExamination();
  
  // Act
  form.BtnCompleteExamination_Click(null, null);

  // Assert
  Assert.IsNull(form.selectedExam);
}

[Test]
public void TestCompleteExamination_WithDiagnosis()
{
  // Arrange
  FormExamination form = new FormExamination();
  form.selectedExam = new Entities.ExaminationRecord(){ ID = "1"};

  string diagnosis = "Diagnosis";

  form.TbDiagnosis.Text = diagnosis;

  // Act
  form.BtnCompleteExamination_Click(null, null);

  // Assert
  Assert.AreEqual(diagnosis, form.selectedExam.Diagnosis);

}

[Test]
public void TestSelectExaminationRecord()
{
  // Arrange
  FormExamination form = new FormExamination();

  Entities.ExaminationRecord exam = new Entities.ExaminationRecord(){
    ID = "1",
    DateAndTime = DateTime.Now,
    PatientID = "P1",
    PhysicianID = "D1"
  };
  
  form.DGVExaminationQueue.DataSource = new List<Entities.ExaminationRecord>(){ exam };

  // Act
  form.DGVExaminationQueue_DoubleClick(null, null);

  // Assert
  Assert.AreEqual(exam.ID, form.selectedExam.ID);
  Assert.AreEqual(exam.DateAndTime, form.selectedExam.DateAndTime);
  Assert.AreEqual(exam.PatientID, form.selectedExam.PatientID);
  Assert.AreEqual(exam.PhysicianID, form.selectedExam.PhysicianID);

}