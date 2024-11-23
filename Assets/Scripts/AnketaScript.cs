using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class AnketaScript : MonoBehaviour
{
    public TMP_InputField nameInputField;
    public TMP_Text nameTmpText;
    
    public TMP_InputField ageInputField;
    public TMP_Text birthDayYearTmpText;
    
    // public TMP_InputField birthDayInputField;
    // public TMP_Text ageOldTmpText;    
    // private void Start() {
    //     nameInputField.onEndEdit.AddListener(NameInputFieldOnEndEdit);
    //     ageInputField.onEndEdit.AddListener(AgeInputFieldOnEndEdit);
    //     birthDayInputField.onEndEdit.AddListener(BirthDayInputFieldOnEndEdit);
    // }
    // private void NameInputFieldOnEndEdit(string text) {
    //     Debug.Log("AnketaScript::NameInputFieldOnEndEdit(); -- text:" + text);
    //     OnButtonUserName();
    // }
    // private void AgeInputFieldOnEndEdit(string text) {
    //     Debug.Log("AnketaScript::AgeInputFieldOnEndEdit(); -- text:" + text);
    //     OnButtonUserAge();
    // }
    
    public void OnButtonUserName() {
        Debug.Log("AnketaScript::OnButtonUserName(); -- nameInputField.text:" + nameInputField.text);
        nameTmpText.text = nameInputField.text;
    }

    public void OnButtonUserAge() {
        Debug.Log("AnketaScript::OnButtonUserAge(); -- ageInputField.text:" + ageInputField.text);
        string ageString = ageInputField.text;
        if (ageString != null && ageString.Length > 0) {
            if (int.TryParse(ageString, out int ageInt)) {
                DateTime dateTime = DateTime.Now;
                dateTime = dateTime.AddYears(-ageInt);
                birthDayYearTmpText.text = dateTime.ToString("yyyy");
            } else {
                birthDayYearTmpText.text = "Нужно только число!";
            }
        } else {
            birthDayYearTmpText.text = "Не должно быть пустой!";
        }
    }

    // private void BirthDayInputFieldOnEndEdit(string text) {
    //     Debug.Log("AnketaScript::BirthDayInputFieldOnEndEdit(); -- text:" + text);
    //     OnButtonUserBirthDay();
    // }

    // public void OnButtonUserBirthDay() {
    //     Debug.Log("AnketaScript::OnButtonUserBirthDay(); -- birthDayInputField.text:" + birthDayInputField.text);
    //     string birthDayString = birthDayInputField.text;
    //     if (birthDayString != null && birthDayString.Length > 0) {
    //         DateTime dateTimeToday = DateTime.Today;
    //         DateTime dateOfBirth = DateTime.Parse(birthDayString);
    //         var a = (dateTimeToday.Year * 100 + dateTimeToday.Month) * 100 + dateTimeToday.Day;
    //         var b = (dateOfBirth.Year * 100 + dateOfBirth.Month) * 100 + dateOfBirth.Day;
    //         int age = ((a - b) / 10000);

    //         Debug.Log("AnketaScript::OnButtonUserBirthDay(); -- dateOfBirth:" + dateOfBirth);
    //         TimeSpan span = dateTimeToday.Subtract ( dateOfBirth );
    //         Debug.Log("AnketaScript::OnButtonUserBirthDay(); -- span:" + span);
            
    //         int days = ((int)span.TotalDays - dateOfBirth.Day)%7;
    //         int weeks = ((int)span.TotalDays/7) - (int)(age*52.14);
    //         ageOldTmpText.text = age + "г. " + weeks + "н." + days + "д.";
    //     } else {
    //         ageOldTmpText.text = "Не должно быть пустой!";
    //     }
    // }
}
