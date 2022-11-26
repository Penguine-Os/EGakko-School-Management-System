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
                     new Subject(1, "Dutch" ),
                     new Subject(2, "French" ),
                     new Subject(3, "English" ),
                     new Subject(4, "German" ),
                     new Subject(5, "Spanish" ),
                     new Subject(6, "Latin" ),
                     new Subject(7, "Mathematics" ),
                     new Subject(8, "Geography" ),
                     new Subject(9, "History" ),
                     new Subject(10,"Biology" ),
                     new Subject(11,"Chemistry" ),
                     new Subject(12,"Physics" ),
                     new Subject(13,"Philosophical subjects" ),
                     new Subject(14,"Physical education" ),
                     new Subject(15,"Applied biochemistry" ),
                     new Subject(16,"Applied chemistry" ),
                     new Subject(17,"Applied physics" ),
                     new Subject(18,"Applied ecology" ),
                     new Subject(19,"Applied computer science" ),
                     new Subject(20,"Scientific work physics" ),
                     new Subject(21,"Scientific work chemistry" ),
                     new Subject(22,"Research competencies" ),
                     new Subject(23,"Seminar" ),
                     new Subject(24,"Natural sciences" ),
                     new Subject(25,"Behavioral sciences" ),
                     new Subject(26,"Cultural sciences" ),
                     new Subject(27,"Human geography" ),
                     new Subject(28,"Touristic culture" ),
                     new Subject(29,"Touristic organization" ),
                     new Subject(30,"Touristic spaces" ),
                     new Subject(31,"Internship" ),
                     new Subject(32,"Economics" ),
                     new Subject(33,"Economics law" ),
                     new Subject(34,"Logistics and maritime cases" ),
                     new Subject(35,"Applied computer science - Dactylo" ),
                     new Subject(36,"Accounting" ),
                     new Subject(37,"Law" ),
                     new Subject(38,"Business Economics" ),
                     new Subject(39,"Economic Geography" ),
                     new Subject(40,"Sales" ),
                     new Subject(41,"Economics seminar" ),
                     new Subject(42,"PAV" ),
                     new Subject(43,"Applied Economics: Law" ),
                     new Subject(44,"Introduction to International Trade" ),
                     new Subject(45,"Duits/Spaans" ),                                
                 });

            modelBuilder.Entity<StudyField>()
                .HasData(new List<StudyField>()
                {
                    new StudyField (1,"Modern Language-Sciences",""),
                    new StudyField (2,"Engineering Sciences",""),
                    new StudyField (3,"Science Mathematics",""),
                    new StudyField (4,"Latin mathematics",""),
                    new StudyField (5,"Latin - Modern Languages",""),
                    new StudyField (6,"latin -  Sciences",""),

                    new StudyField (7,"Human Sciences",""),
                    new StudyField (8,"Tourism",""),

                    new StudyField (9,"Economics - Mathematics",""),
                    new StudyField (10,"Economy - Modern Languages",""),
                    new StudyField (11,"Commerce",""),
                    new StudyField (12,"Logistical Maritime Administration",""),

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

            modelBuilder.Entity<Class>()
                .HasData(new List<Class>
                {
                    new Class(1,"3A"),
                    new Class(2,"4A"),
                    new Class(3,"5A"),
                    new Class(4,"6A"),
                    new Class(5,"6B"),
                });

            modelBuilder.Entity<ClassRoomLocation>()
                .HasData(new List<ClassRoomLocation>
                {
                    new ClassRoomLocation(1, 25,"A101"),
                    new ClassRoomLocation(2, 15,"A102"),
                    new ClassRoomLocation(3, 30,"A103"),
                    new ClassRoomLocation(4, 20,"A104"),
                    new ClassRoomLocation(5, 25,"A105"),
                    new ClassRoomLocation(6, 20,"B101"),
                    new ClassRoomLocation(7, 20,"B102"),
                    new ClassRoomLocation(8, 15,"B103"),
                    new ClassRoomLocation(9, 15,"B104"),
                    new ClassRoomLocation(10,30,"B105"),
                    new ClassRoomLocation(11,30,"C101"),
                    new ClassRoomLocation(12,20,"C102"),
                    new ClassRoomLocation(13,15,"C103"),
                    new ClassRoomLocation(14,15,"C104"),
                    new ClassRoomLocation(15,25,"C105"),
                    new ClassRoomLocation(16,25,"B101"),
                    new ClassRoomLocation(17,20,"B102"),
                    new ClassRoomLocation(18,30,"B103"),
                    new ClassRoomLocation(19,20,"B104"),
                    new ClassRoomLocation(20,15,"B105"),
                });
        }

       }
}