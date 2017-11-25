using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MCSI.UWP.HROpen.Common.Models;
using Windows.Storage;
using System.Collections.ObjectModel;
using Newtonsoft.Json;

namespace MCSI.UWP.HROpen.Utilities
{
    public static class Repository
    {
       // private object newFolder;

        public static async Task<Boolean> SavePerson(PersonType person)
        {
            Boolean result = false;
            string personData = string.Empty;

            try
            {
                personData = person.ToJson();

                //for now just store it locally;
                StorageFolder folder = ApplicationData.Current.LocalFolder;
                StorageFile textFile = await folder.CreateFileAsync("PersonType.txt",CreationCollisionOption.ReplaceExisting);
                await FileIO.WriteTextAsync(textFile, personData);
                result = true;

            }
            catch (Exception ex)
            {

                throw ex;
            }


            return result;

        }

        public static  async Task<PersonType> GetPerson()
        {
            PersonType result = null;

            try
            {
                StorageFolder folder = ApplicationData.Current.LocalFolder;
                StorageFile file = await folder.GetFileAsync("PersonType.txt");//   .GetFilesAsync();
                string json = await FileIO.ReadTextAsync(file);
                result = JsonConvert.DeserializeObject<PersonType>(json);


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

            return result;

        }

    }
}
