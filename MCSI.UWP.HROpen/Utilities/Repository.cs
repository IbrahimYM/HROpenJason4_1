using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MCSI.UWP.HROpen.Common.Models;
using Windows.Storage;
using System.Collections.ObjectModel;
using Newtonsoft.Json;
using Windows.Storage.Pickers;

namespace MCSI.UWP.HROpen.Utilities
{
    public static class Repository
    {
        // private object newFolder;

        
        private static PersonType _currentPerson;
        private static string _personCompare = string.Empty;

        #region static public behaviors
        public static async Task<Boolean> SavePersonToFile(PersonType person)
        {
            Boolean result = false;
            string personData = string.Empty;

            try
            {
                personData = person.ToJson();

                FileSavePicker savePicker = new FileSavePicker();
                savePicker.FileTypeChoices.Add("HROpen Person", new List<string>() { ".hrj" });
                savePicker.FileTypeChoices.Add("JSON File", new List<string>() { ".json" });
                savePicker.FileTypeChoices.Add("Text File", new List<string>() { ".txt" });
                savePicker.DefaultFileExtension = ".hrj";
                savePicker.SuggestedFileName = person.Name.FormattedName;
                StorageFile itemToSave = await savePicker.PickSaveFileAsync();


                if (itemToSave != null)
                {

                    await Windows.Storage.FileIO.WriteTextAsync(itemToSave, personData);
                    _personCompare = CurrentPerson.ToJson();
                    result = true;
                }

               

            }
            catch (Exception ex)
            {

                throw ex;
            }


            return result;

        }

        public static  async Task<string> GetPersonFromFile(string filePath)
        {
           string result = string.Empty;

            try
            {

                FileOpenPicker openPicker = new FileOpenPicker();
                openPicker.ViewMode = PickerViewMode.Thumbnail;
                openPicker.SuggestedStartLocation = PickerLocationId.DocumentsLibrary;

                openPicker.FileTypeFilter.Add("*");
                openPicker.FileTypeFilter.Add(".hrj");

                StorageFile file = await openPicker.PickSingleFileAsync();

                // StorageFolder folder = ApplicationData.Current.LocalFolder;
                //  StorageFile file = await folder.GetFileAsync("PersonType.txt");//   .GetFilesAsync();

                if (file != null)
                {
                    string json = await FileIO.ReadTextAsync(file);
                    CurrentPerson = JsonConvert.DeserializeObject<PersonType>(json) ?? null;
                    _personCompare = CurrentPerson.ToJson();
                    result = file.Path;
                }


            }
            catch (Exception)
            {

                throw;
            }

            return result;
        }

        public static PersonType CreateNewPerson()
        {
            PersonType result = new PersonType();

            result.Name = new PersonNameType() { FormattedName = "Name Not Provided" };
            result.Id = new IdentifierType() { Value = "Not Provided" };
            result.LegalId = new IdentifierType() { Value = "Not Provided" };
            result.Licenses = new ObservableCollection<LicenseType>();
            result.IdentifyingMarks = new ObservableCollection<string>();
            result.Nationality = new ObservableCollection<string>();
            result.PassportId = new IdentifierType() { Value = "Not Provided" };
            result.Patents = new ObservableCollection<PatentType>();
            result.Publications = new ObservableCollection<PublicationType>();
            result.Qualifications = new ObservableCollection<PersonCompetencyType>();
            result.Race = new ObservableCollection<string>();
            result.References = new ObservableCollection<RefereeType>();
            result.ResidenceCountry = new ObservableCollection<CountryCodeList>();
            result.SecurityCredentials = new ObservableCollection<SecurityCredentialType>();
            result.Visa = new ObservableCollection<string>();
            result.Affiliations = new ObservableCollection<OrganizationAffiliationType>();
            result.Attachments = new ObservableCollection<AttachmentType>();
            result.Certifications = new ObservableCollection<CertificationType>();
            result.Citizenship = new ObservableCollection<CountryCodeList>();
            result.Education = new ObservableCollection<EducationAttendanceType>();
            result.Employment = new ObservableCollection<EmployerHistoryType>();
            result.Ethnicity = new ObservableCollection<string>();

            _personCompare = result.ToJson();
            return result;

        }

       

        public static Boolean IsCurrentPersonDirty()
        { 
            return _currentPerson==null?false:!_currentPerson.ToJson().Equals(_personCompare);
        }

        public static string CurrentPersonStatus()
        {
            return IsCurrentPersonDirty() ? "Current Person has unsaved changes" : "Current Person Unchanged";
        }

        #endregion
        #region public static properties

        //the current instance of the PersonType
        public static PersonType CurrentPerson
        {
            get { return _currentPerson ?? CreateNewPerson(); }

            set
            {
                _currentPerson = value;
                // _personCompare = _currentPerson.ToJson();
            }
        }

        #endregion

    }
}
