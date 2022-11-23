using EGakko_Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;

namespace EGakko_Web.Extensions
{
    public static class ModelBuilderExtension
    {
        internal static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Subject>()
                 .HasData(new List<Subject>()
                 {
                     new Subject() { Id = 1, Name = "Dutch" },
                     new Subject() { Id = 2, Name = "French" },
                     new Subject() { Id = 3, Name = "English" },
                     new Subject() { Id = 4, Name = "German" },
                     new Subject() { Id = 5, Name = "Spanish" },
                     new Subject() { Id = 6, Name = "Latin" },
                     new Subject() { Id = 7, Name = "Mathematics" },
                     new Subject() { Id = 8, Name = "Geography" },
                     new Subject() { Id = 9, Name = "History" },
                     new Subject() { Id = 10, Name = "Biology" },
                     new Subject() { Id = 11, Name = "Chemistry" },
                     new Subject() { Id = 12, Name = "Physics" },
                     new Subject() { Id = 13, Name = "Philosophical subjects\r\n" },
                     new Subject() { Id = 14, Name = "Physical education" },
                     new Subject() { Id = 15, Name = "Applied biochemistry" },
                     new Subject() { Id = 16, Name = "Applied chemistry" },
                     new Subject() { Id = 17, Name = "Applied physics" },
                     new Subject() { Id = 18, Name = "Applied ecology" },
                     new Subject() { Id = 19, Name = "Applied computer science" },
                     new Subject() { Id = 20, Name = "Scientific work physics" },
                     new Subject() { Id = 21, Name = "Scientific work chemistry" },
                     new Subject() { Id = 22, Name = "Research competencies" },
                     new Subject() { Id = 23, Name = "Seminar" },
                     new Subject() { Id = 24, Name = "Natural sciences" },
                     new Subject() { Id = 25, Name = "Behavioral sciences" },
                     new Subject() { Id = 26, Name = "Cultural sciences" },
                     new Subject() { Id = 27, Name = "Human geography" },
                     new Subject() { Id = 28, Name = "Touristic culture" },
                     new Subject() { Id = 29, Name = "Touristic organization" },
                     new Subject() { Id = 30, Name = "Touristic spaces" },
                     new Subject() { Id = 31, Name = "Internship" },
                     new Subject() { Id = 32, Name = "Economics" },
                     new Subject() { Id = 33, Name = "Economics law" },
                     new Subject() { Id = 34, Name = "Logistics and maritime cases" },
                     new Subject() { Id = 35, Name = "Applied computer science / Dactylo" },
                     new Subject() { Id = 36, Name = "Accounting" },
                     new Subject() { Id = 37, Name = "Law" },
                     new Subject() { Id = 38, Name = "Business Economics" },
                     new Subject() { Id = 39, Name = "Economic Geography" },
                     new Subject() { Id = 40, Name = "Sales" },
                     new Subject() { Id = 41, Name = "Economics seminar" },
                     new Subject() { Id = 42, Name = "PAV" },
                     new Subject() { Id = 43, Name = "Applied Economics: Law" },
                     new Subject() { Id = 44, Name = "Introduction to International Trade" },
                     new Subject() { Id = 45, Name = "Duits/Spaans" },
                 });
            modelBuilder.Entity<StudyField>()
                .HasData(new List<StudyField>()
                {
                    new StudyField {Id=1, Name="Modern Language-Sciences", GradeLevel= "3rd Degree"},
                    new StudyField {Id=2, Name="Engineering Sciences", GradeLevel= "3rd Degree"},
                    new StudyField {Id=3, Name="Science Mathematics", GradeLevel= "3rd Degree"},

                    new StudyField {Id=4, Name="Latin mathematics", GradeLevel= "3rd Degree"},
                    new StudyField {Id=5, Name="Latin - Modern Languages", GradeLevel= "3rd Degree"},
                    new StudyField {Id=6, Name="latin -  Sciences", GradeLevel= "3rd Degree"},

                    new StudyField {Id=7, Name="Human Sciences", GradeLevel= "3rd Degree"},
                    new StudyField {Id=8, Name="Tourism", GradeLevel= "3rd Degree"},

                    new StudyField {Id=9, Name="Economics - Mathematics", GradeLevel= "3rd Degree"},
                    new StudyField {Id=10, Name="Economy - Modern Languages", GradeLevel= "3rd Degree"},
                    new StudyField {Id=11, Name="Commerce", GradeLevel= "3rd Degree"},
                    new StudyField {Id=12, Name="Logistical Maritime Administration", GradeLevel= "3rd Degree"},

                });

            modelBuilder.Entity<FieldSubject>()
                .HasData(new List<FieldSubject>()
                {
                    new FieldSubject (){ Id =1, IsCoreSubject = true, HoursPerWeek = 5, FieldId = 1, SubjectId = 1 }, // Nederlands
                    new FieldSubject (){ Id =2, IsCoreSubject = true, HoursPerWeek = 4, FieldId = 1, SubjectId = 2 }, // Frans
                    new FieldSubject (){ Id =3, IsCoreSubject = false, HoursPerWeek = 3, FieldId = 1, SubjectId = 3 },// Engels 
                    new FieldSubject (){ Id =4, IsCoreSubject = false, HoursPerWeek = 2, FieldId = 1, SubjectId = 45 },// Duits/Spaans
                    new FieldSubject (){ Id =5, IsCoreSubject = true, HoursPerWeek = 5, FieldId = 1, SubjectId = 7 },// Wiskunde
                    new FieldSubject (){ Id =6, IsCoreSubject = false, HoursPerWeek = 2, FieldId = 1, SubjectId = 8 },// Aardrijkskunde
                    new FieldSubject (){ Id =7, IsCoreSubject = false, HoursPerWeek = 2, FieldId = 1, SubjectId = 9 },// Geschiedenis
                    new FieldSubject (){ Id =8, IsCoreSubject = false, HoursPerWeek = 2, FieldId = 1, SubjectId = 10 },// Biologie
                    new FieldSubject (){ Id =9, IsCoreSubject = false, HoursPerWeek = 2, FieldId = 1, SubjectId = 11 },// Chemie
                    new FieldSubject (){ Id =10, IsCoreSubject = false, HoursPerWeek = 2, FieldId = 1, SubjectId = 12 },// Fysica
                    new FieldSubject (){ Id =11, IsCoreSubject = false, HoursPerWeek = 2, FieldId = 1, SubjectId = 13 },// Levensbeschouwelijke vakken
                    new FieldSubject (){ Id =12, IsCoreSubject = false, HoursPerWeek = 2, FieldId = 1, SubjectId = 14 },// Lichamelijke opvoeding
                
                    new FieldSubject (){ Id =13, IsCoreSubject = false, HoursPerWeek = 3, FieldId = 2, SubjectId = 1 }, // Nederlands
                    new FieldSubject (){ Id =14, IsCoreSubject = false, HoursPerWeek = 2, FieldId = 2, SubjectId = 2 },// Frans
                    new FieldSubject (){ Id =15, IsCoreSubject = false, HoursPerWeek = 2, FieldId = 2, SubjectId = 3 },// Engels 
                    new FieldSubject (){ Id =16, IsCoreSubject = true,  HoursPerWeek = 4, FieldId = 2, SubjectId = 7 },// Wiskunde
                    new FieldSubject (){ Id =17, IsCoreSubject = false, HoursPerWeek = 2, FieldId = 2, SubjectId = 8 },// Aardrijkskunde
                    new FieldSubject (){ Id =18, IsCoreSubject = false, HoursPerWeek = 1, FieldId = 2, SubjectId = 9 },// Geschiedenis
                    new FieldSubject (){ Id =19, IsCoreSubject = false, HoursPerWeek = 2, FieldId = 2, SubjectId = 13 },// Levensbeschouwelijke vakken
                    new FieldSubject (){ Id =20, IsCoreSubject = false, HoursPerWeek = 2, FieldId = 2, SubjectId = 14 },// Lichamelijke opvoeding
                    new FieldSubject (){ Id =21, IsCoreSubject = false, HoursPerWeek = 3, FieldId = 2, SubjectId = 10 },// Biologie
                    new FieldSubject (){ Id =22, IsCoreSubject = false, HoursPerWeek = 3, FieldId = 2, SubjectId = 15 }, // Toegepast biochemie
                    new FieldSubject (){ Id =23, IsCoreSubject = false, HoursPerWeek = 3, FieldId = 2, SubjectId = 16 }, // Toegepast chemie
                    new FieldSubject (){ Id =24, IsCoreSubject = false, HoursPerWeek = 3, FieldId = 2, SubjectId = 17 }, // Toegepast fysica
                    new FieldSubject (){ Id =25, IsCoreSubject = false, HoursPerWeek = 3, FieldId = 2, SubjectId = 18 }, // Toegepast ecologie
                    new FieldSubject (){ Id =26, IsCoreSubject = false, HoursPerWeek = 1, FieldId = 2, SubjectId = 19 }, // Toegepast informatica
                
                    new FieldSubject (){ Id =27, IsCoreSubject = true , HoursPerWeek = 5, FieldId = 3, SubjectId = 1 }, // Nederlands
                    new FieldSubject (){ Id =28, IsCoreSubject = false, HoursPerWeek = 3, FieldId = 3, SubjectId = 2 },// Frans
                    new FieldSubject (){ Id =29, IsCoreSubject = false, HoursPerWeek = 2, FieldId = 3, SubjectId = 3 },// Engels 
                    new FieldSubject (){ Id =30, IsCoreSubject = true,  HoursPerWeek = 7, FieldId = 3, SubjectId = 7 },// Wiskunde
                    new FieldSubject (){ Id =31, IsCoreSubject = false, HoursPerWeek = 2, FieldId = 3, SubjectId = 8 },// Aardrijkskunde
                    new FieldSubject (){ Id =32, IsCoreSubject = false, HoursPerWeek = 2, FieldId = 3, SubjectId = 9 },// Geschiedenis
                    new FieldSubject (){ Id =33, IsCoreSubject = false, HoursPerWeek = 2, FieldId = 3, SubjectId = 13 },// Levensbeschouwelijke vakken
                    new FieldSubject (){ Id =34, IsCoreSubject = false, HoursPerWeek = 2, FieldId = 3, SubjectId = 14 },// Lichamelijke opvoeding
                    new FieldSubject (){ Id =35, IsCoreSubject = false, HoursPerWeek = 2, FieldId = 3, SubjectId = 10 }, // Biologie
                    new FieldSubject (){ Id =36, IsCoreSubject = false, HoursPerWeek = 2, FieldId = 3, SubjectId = 11 }, // Chemie
                    new FieldSubject (){ Id =37, IsCoreSubject = false, HoursPerWeek = 2, FieldId = 3, SubjectId = 12 }, // Fysica
                    new FieldSubject (){ Id =38, IsCoreSubject = false, HoursPerWeek = 1, FieldId = 3, SubjectId = 20 }, // Wetenschappelijk werk fysica
                    new FieldSubject (){ Id =39, IsCoreSubject = false, HoursPerWeek = 1, FieldId = 3, SubjectId = 21 }, // Wetenschappelijk werk chemie
                
                    new FieldSubject (){ Id =40, IsCoreSubject = true , HoursPerWeek = 5, FieldId = 4, SubjectId = 1 }, // Nederlands
                    new FieldSubject (){ Id =41, IsCoreSubject = false, HoursPerWeek = 3, FieldId = 4, SubjectId = 2 },// Frans
                    new FieldSubject (){ Id =42, IsCoreSubject = false, HoursPerWeek = 2, FieldId = 4, SubjectId = 3 },// Engels 
                    new FieldSubject (){ Id =43, IsCoreSubject = true , HoursPerWeek = 4, FieldId = 4, SubjectId = 6 },// Latijn 
                    new FieldSubject (){ Id =44, IsCoreSubject = true,  HoursPerWeek = 7, FieldId = 4, SubjectId = 7 },// Wiskunde
                    new FieldSubject (){ Id =45, IsCoreSubject = false, HoursPerWeek = 1, FieldId = 4, SubjectId = 8 },// Aardrijkskunde
                    new FieldSubject (){ Id =46, IsCoreSubject = false, HoursPerWeek = 2, FieldId = 4, SubjectId = 9 },// Geschiedenis
                    new FieldSubject (){ Id =47, IsCoreSubject = false, HoursPerWeek = 2, FieldId = 4, SubjectId = 13 },// Levensbeschouwelijke vakken
                    new FieldSubject (){ Id =48, IsCoreSubject = false, HoursPerWeek = 2, FieldId = 4, SubjectId = 14 },// Lichamelijke opvoeding
                    new FieldSubject (){ Id =49, IsCoreSubject = false, HoursPerWeek = 1, FieldId = 4, SubjectId = 10 }, // Biologie
                    new FieldSubject (){ Id =50, IsCoreSubject = false, HoursPerWeek = 2, FieldId = 4, SubjectId = 11 }, // Chemie
                    new FieldSubject (){ Id =51, IsCoreSubject = false, HoursPerWeek = 2, FieldId = 4, SubjectId = 12 }, // Fysica
                 
                    new FieldSubject (){ Id =52, IsCoreSubject = true , HoursPerWeek = 5, FieldId = 5, SubjectId = 1 }, // Nederlands
                    new FieldSubject (){ Id =53, IsCoreSubject = false, HoursPerWeek = 4, FieldId = 5, SubjectId = 2 },// Frans
                    new FieldSubject (){ Id =54, IsCoreSubject = false, HoursPerWeek = 3, FieldId = 5, SubjectId = 3 },// Engels 
                    new FieldSubject (){ Id =55, IsCoreSubject = true , HoursPerWeek = 4, FieldId = 5, SubjectId = 6 },// Latijn 
                    new FieldSubject (){ Id =56, IsCoreSubject = true,  HoursPerWeek = 3, FieldId = 5, SubjectId = 7 },// Wiskunde
                    new FieldSubject (){ Id =57, IsCoreSubject = false, HoursPerWeek = 1, FieldId = 5, SubjectId = 8 },// Aardrijkskunde
                    new FieldSubject (){ Id =58, IsCoreSubject = false, HoursPerWeek = 2, FieldId = 5, SubjectId = 9 },// Geschiedenis
                    new FieldSubject (){ Id =59, IsCoreSubject = false, HoursPerWeek = 2, FieldId = 5, SubjectId = 13 },// Levensbeschouwelijke vakken
                    new FieldSubject (){ Id =60, IsCoreSubject = false, HoursPerWeek = 2, FieldId = 5, SubjectId = 14 },// Lichamelijke opvoeding
                    new FieldSubject (){ Id =61, IsCoreSubject = false, HoursPerWeek = 1, FieldId = 5, SubjectId = 22 }, // Onderzoekscompetenties
                    new FieldSubject (){ Id =62, IsCoreSubject = false, HoursPerWeek = 2, FieldId = 5, SubjectId = 23 }, // Seminarie
                    new FieldSubject (){ Id =63, IsCoreSubject = false, HoursPerWeek = 2, FieldId = 5, SubjectId = 24 }, // Natuurwetenschappen
                    new FieldSubject (){ Id =64, IsCoreSubject = false, HoursPerWeek = 2, FieldId = 5, SubjectId = 45 }, // DUITS/SPAANS
                 
                    new FieldSubject (){ Id =65, IsCoreSubject = true , HoursPerWeek = 5, FieldId = 6, SubjectId = 1 }, // Nederlands
                    new FieldSubject (){ Id =66, IsCoreSubject = false, HoursPerWeek = 3, FieldId = 6, SubjectId = 2 },// Frans
                    new FieldSubject (){ Id =67, IsCoreSubject = false, HoursPerWeek = 2, FieldId = 6, SubjectId = 3 },// Engels 
                    new FieldSubject (){ Id =68, IsCoreSubject = true , HoursPerWeek = 4, FieldId = 6, SubjectId = 6 },// Latijn 
                    new FieldSubject (){ Id =69, IsCoreSubject = true,  HoursPerWeek = 5, FieldId = 6, SubjectId = 7 },// Wiskunde
                    new FieldSubject (){ Id =70, IsCoreSubject = false, HoursPerWeek = 2, FieldId = 6, SubjectId = 8 },// Aardrijkskunde
                    new FieldSubject (){ Id =71, IsCoreSubject = false, HoursPerWeek = 2, FieldId = 6, SubjectId = 9 },// Geschiedenis
                    new FieldSubject (){ Id =72, IsCoreSubject = false, HoursPerWeek = 2, FieldId = 6, SubjectId = 13 },// Levensbeschouwelijke vakken
                    new FieldSubject (){ Id =73, IsCoreSubject = false, HoursPerWeek = 2, FieldId = 6, SubjectId = 14 },// Lichamelijke opvoeding
                    new FieldSubject (){ Id =74, IsCoreSubject = false, HoursPerWeek = 2, FieldId = 6, SubjectId = 10 }, // Biologie
                    new FieldSubject (){ Id =75, IsCoreSubject = false, HoursPerWeek = 2, FieldId = 6, SubjectId = 11 }, // Chemie
                    new FieldSubject (){ Id =76, IsCoreSubject = false, HoursPerWeek = 2, FieldId = 6, SubjectId = 12 }, // Fysica
                
                    new FieldSubject (){ Id =77, IsCoreSubject = true , HoursPerWeek = 5, FieldId = 7, SubjectId = 1 }, // Nederlands
                    new FieldSubject (){ Id =78, IsCoreSubject = false, HoursPerWeek = 3, FieldId = 7, SubjectId = 2 },// Frans
                    new FieldSubject (){ Id =79, IsCoreSubject = false, HoursPerWeek = 2, FieldId = 7, SubjectId = 3 },// Engels 
                    new FieldSubject (){ Id =80, IsCoreSubject = false, HoursPerWeek = 2, FieldId = 7, SubjectId = 45 },// DUITS/SPAANS 
                    new FieldSubject (){ Id =81, IsCoreSubject = false, HoursPerWeek = 3, FieldId = 7, SubjectId = 7 },// Wiskunde
                    new FieldSubject (){ Id =82, IsCoreSubject = false, HoursPerWeek = 2, FieldId = 7, SubjectId = 8 },// Aardrijkskunde
                    new FieldSubject (){ Id =83, IsCoreSubject = false, HoursPerWeek = 2, FieldId = 7, SubjectId = 9 },// Geschiedenis
                    new FieldSubject (){ Id =84, IsCoreSubject = false, HoursPerWeek = 2, FieldId = 7, SubjectId = 13 },// Levensbeschouwelijke vakken
                    new FieldSubject (){ Id =85, IsCoreSubject = false, HoursPerWeek = 2, FieldId = 7, SubjectId = 14 },// Lichamelijke opvoeding
                    new FieldSubject (){ Id =86, IsCoreSubject = false, HoursPerWeek = 1, FieldId = 7, SubjectId = 23 }, // seminarie
                    new FieldSubject (){ Id =87, IsCoreSubject = true , HoursPerWeek = 4, FieldId = 7, SubjectId = 25 }, // Gedragswetenschappen
                    new FieldSubject (){ Id =88, IsCoreSubject = false, HoursPerWeek = 2, FieldId = 7, SubjectId = 24 }, // Natuurwetenschappen
                    new FieldSubject (){ Id =89, IsCoreSubject = false, HoursPerWeek = 3, FieldId = 7, SubjectId = 26 }, // Cultuurwetenschappen

                    new FieldSubject (){ Id =90, IsCoreSubject = false, HoursPerWeek = 4, FieldId = 2, SubjectId = 1 }, // Nederlands
                    new FieldSubject (){ Id =91, IsCoreSubject = false, HoursPerWeek = 3, FieldId = 2, SubjectId = 2 },// Frans
                    new FieldSubject (){ Id =92, IsCoreSubject = false, HoursPerWeek = 3, FieldId = 2, SubjectId = 3 },// Engels 
                    new FieldSubject (){ Id =93, IsCoreSubject = true,  HoursPerWeek = 2, FieldId = 2, SubjectId = 7 },// Wiskunde
                    new FieldSubject (){ Id =94, IsCoreSubject = false, HoursPerWeek = 1, FieldId = 2, SubjectId = 8 },// Aardrijkskunde
                    new FieldSubject (){ Id =95, IsCoreSubject = false, HoursPerWeek = 1, FieldId = 2, SubjectId = 9 },// Geschiedenis
                    new FieldSubject (){ Id =96, IsCoreSubject = false, HoursPerWeek = 2, FieldId = 2, SubjectId = 13 },// Levensbeschouwelijke vakken
                    new FieldSubject (){ Id =97, IsCoreSubject = false, HoursPerWeek = 2, FieldId = 2, SubjectId = 14 },// Lichamelijke opvoeding
                    new FieldSubject (){ Id =98, IsCoreSubject = false, HoursPerWeek = 1, FieldId = 2, SubjectId = 24 },// Natuurwetenschappen
                    new FieldSubject (){ Id =99, IsCoreSubject = false, HoursPerWeek = 3, FieldId = 2, SubjectId = 5 }, // spaans
                    new FieldSubject (){ Id =100, IsCoreSubject = false, HoursPerWeek = 2, FieldId = 2, SubjectId = 28 }, // Toeristische cultuur
                    new FieldSubject (){ Id =101, IsCoreSubject = false, HoursPerWeek = 2, FieldId = 2, SubjectId = 29 }, // Toeristische organisatie
                    new FieldSubject (){ Id =102, IsCoreSubject = false, HoursPerWeek = 2, FieldId = 2, SubjectId = 30 }, // Toeristische ruimte
                    new FieldSubject (){ Id =103, IsCoreSubject = false, HoursPerWeek = 7, FieldId = 2, SubjectId = 31 }, // internship
                    new FieldSubject (){ Id =104, IsCoreSubject = false, HoursPerWeek = 1, FieldId = 2, SubjectId = 19 }, // Toegepast informatica
                 });

            
        }
       }
}