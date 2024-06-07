using Microsoft.EntityFrameworkCore;
using UniversityRanking.Data;
using UniversityRanking.Models;

namespace UniversityRanking.DbInitializer;

public class DbInitializer : IDbInitializer
{
    private readonly AppDbContext _context;

    public DbInitializer(AppDbContext context)
    {
        _context = context;
    }
    
    public void Initialize()
    {
        if (!_context.Database.CanConnect()
            || !_context.Database.GetPendingMigrations().Any())
        {
            _context.Database.Migrate();
        }

        if (!_context.MainSubjects.Any())
        {
            _context.MainSubjects.AddRange(new List<MainSubject>
            {
                new()
                {
                    LogoUrl = @"https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.brandcrowd.com%2Fblog%2Fharvard-university-logo-history%2F&psig=AOvVaw0B9VEZuDTIyeYmBwz_9Nex&ust=1717798964384000&source=images&cd=vfe&opi=89978449&ved=0CBIQjRxqFwoTCLDM5vqByIYDFQAAAAAdAAAAABAE",
                    Title = "Academic reputation",
                    AcademicReputations = new()
                    {
                        LogoUrl = @"https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.brandcrowd.com%2Fblog%2Fharvard-university-logo-history%2F&psig=AOvVaw0B9VEZuDTIyeYmBwz_9Nex&ust=1717798964384000&source=images&cd=vfe&opi=89978449&ved=0CBIQjRxqFwoTCLDM5vqByIYDFQAAAAAdAAAAABAE",
                        AcademicReputationScore = 30.82,
                        Title = "Academic reputation",
                        FacultyQuality = 45.91,
                        StudentSatisfaction = 87.65,
                        InternationalCollaboration = 30.0,
                        AwardsAndRecognitions = "-",
                        Year = 2024
                    }
                },
                new()
                {
                    LogoUrl = @"https://nure.ua/wp-content/uploads/Benchmarking/4.-rating-and-payment.pdf;https://nure.ua/wp-content/uploads/Benchmarking/nakaz-pro-prodovzhennja-stroku-dii-kolektivnogo-dogovoru.pdf",
                    Title = "Employer Reputation",
                    EmployerReputation = new()
                    {
                        EvidenceUrl = @"https://nure.ua/wp-content/uploads/Benchmarking/4.-rating-and-payment.pdf;https://nure.ua/wp-content/uploads/Benchmarking/nakaz-pro-prodovzhennja-stroku-dii-kolektivnogo-dogovoru.pdf",
                        ExpenditurePerEmployees = 326_346_245.00,
                        LogoUrl = @"https://tse3.mm.bing.net/th/id/OIG3.gGxBjRspfINeQVTbc8Xc?pid=ImgGn",
                        AverageSalary = 326_346_245.00/1670,
                        Title = "Employer Reputation",
                        EmployerReputationScore = 50,
                        EmployerFeedback = @"https://nure.ua/wp-content/uploads/Benchmarking/polityka-rivnosti-5.pdf;https://nure.ua/en/public/primary-trade-union-organization/the-labor-dispute-commission-nure",
                        JobPlacementRate = 32.85,
                        Year = 2024
                    }
                },
                new()
                {
                    Title = "Citation",
                    LogoUrl = @"https://tse2.mm.bing.net/th/id/OIG1.tupm1ddtR1IbfMC.Tscv?pid=ImgGn",
                    Citation = new()
                    {
                        CitationCount = 1578,
                        PublicationCount = 5074,
                        Title = "Citation",
                        LogoUrl = @"https://tse2.mm.bing.net/th/id/OIG1.tupm1ddtR1IbfMC.Tscv?pid=ImgGn",
                        HIndex = 20,
                        Year = 2024
                    }
                },
                new()
                {
                    Title = "Employment Result",
                    LogoUrl = @"https://tse2.mm.bing.net/th/id/OIG4.syCTxzl2_BugaMeV.6iX?pid=ImgGn",
                    EmploymentResult = new()
                    {
                        EmploymentRate = 95.91,
                        LogoUrl = @"https://tse2.mm.bing.net/th/id/OIG4.syCTxzl2_BugaMeV.6iX?pid=ImgGn",
                        AverageSalary = 17456.56,
                        Title = "Employment Result",
                        TopEmployers = "Nix;SigmaSoftware;Genesis;SoftServe;Intellias",
                        EmploymentSectors = "IT;Science;Economy;Cybersecurity;CivilianSecurity",
                        SurveyYear = 2024
                    }
                },
                new()
                {
                    Title = "Faculty Student Ratio",
                    LogoUrl = @"https://tse1.mm.bing.net/th/id/OIG1.ebYee3njj0iPVoKMDKMg?pid=ImgGn",
                    FacultyStudentRatio = new()
                    {
                        Degree = "Bachelor",
                        LogoUrl = @"https://tse1.mm.bing.net/th/id/OIG1.ebYee3njj0iPVoKMDKMg?pid=ImgGn",
                        Specialization = "123-Computer engineering",
                        StudentCount = 7684,
                        Title = "Faculty Student Ratio",
                        FemaleAmount = 7684/3,
                        MaleAmount = 7684-(7684/3)
                    }
                },
                new()
                {
                    Title = "International Teachers Ratio",
                    LogoUrl = @"https://tse3.mm.bing.net/th/id/OIG3.uzh1tfnkg7Y2wWrKmhxp?pid=ImgGn",
                    InternationalTeachersRatio = new()
                    {
                        TeacherCountries = "USA;France;Poland;Italy;Germany;Greece;Tokyo",
                        SuperiorCountry = "Tokyo",
                        Title = "International Teachers Ratio",
                        LogoUrl = @"https://tse3.mm.bing.net/th/id/OIG3.uzh1tfnkg7Y2wWrKmhxp?pid=ImgGn",
                        InternationalTeacherAmount = 100,
                        TeachersAmount = 706
                    }
                },
                new()
                {
                    Title = "Foreign Student Ratio",
                    LogoUrl = @"https://tse2.mm.bing.net/th/id/OIG3.TJWCS3uwK.xlEovaibTJ?pid=ImgGn",
                    ForeignStudentRatio = new()
                    {
                        StudentCountries =  "USA;France;Poland;Italy;Germany;Greece;Tokyo",
                        SuperiorCountry = "USA",
                        Title = "Foreign Student Ratio",
                        LogoUrl = @"https://tse2.mm.bing.net/th/id/OIG3.TJWCS3uwK.xlEovaibTJ?pid=ImgGn",
                        InternationalStudentAmount = 7684,
                        StudentAmount = 250
                    }
                },
                new()
                {
                    Title = "Research Network",
                    LogoUrl = @"https://tse2.mm.bing.net/th/id/OIG4._FA4euGOWd4Nnq6zhlJF?pid=ImgGn",
                    ResearchNetwork = new()
                    {
                        Name = "Global Education Research Network (GERN)",
                        Title = "Research Network",
                        Description = "The Global Education Research Network (GERN) is a collaborative initiative aimed at fostering international cooperation in the field of education research. Our mission is to promote knowledge exchange, facilitate joint research projects, and enhance the global impact of educational research. We believe in the power of shared knowledge and collaboration to address the complex challenges of education in the 21st century.",
                        CollaboratingOrganizations = "United Nations Educational, Scientific and Cultural Organization (UNESCO);World Bank;British Council;International Council for Open and Distance Education (ICDE);African Educational Research Network (AERN)",
                        Members = "Dr. Alice Johnson;Prof. Robert Smith;Dr. Emily White;Prof. David Brown;Dr. Olivia Davis;Prof. William Miller",
                        LogoUrl = @"https://tse2.mm.bing.net/th/id/OIG4._FA4euGOWd4Nnq6zhlJF?pid=ImgGn"
                    }
                },
                new()
                {
                    Title = "Student Stability",
                    LogoUrl = @"https://tse4.mm.bing.net/th/id/OIG2.T.IuNKkNIll51oNq2ZNA?pid=ImgGn",
                    StudentStability = new()
                    {
                        CountryName = "Ukraine",
                        TotalStudents = 7684,
                        StudentsMoved = 2500,
                        Title = "Student Stability",
                        StudentsRemaining = 7684-2500,
                        OtherDetails = "The war in Ukraine erupted in 2014 following Russia’s annexation of Crimea1. This conflict intensified with Russia’s full-scale invasion, launching air strikes and ground attacks from multiple fronts2. The invasion led to widespread displacement and loss of lives3. Ukraine’s resistance against this military aggression continues, despite being outnumbered and outgunned4. This conflict has significantly strained Ukraine’s relations with Russia and has had profound global implications",
                        LogoUrl = @"https://tse4.mm.bing.net/th/id/OIG2.T.IuNKkNIll51oNq2ZNA?pid=ImgGn"
                    }
                }
            });
            
            _context.SaveChanges();
        }
        
        if (!_context.Universities.Any())
        {
            _context.Universities.Add(new University
            {
                Name = "Kharkiv National University of Radio Electronics",
                FoundationDate = new DateTime(1930, 11, 8, 0, 0, 0),
                Logo = @"https://upload.wikimedia.org/wikipedia/commons/thumb/a/a6/Nure-brand-book-1-1024_cr2.jpg/220px-Nure-brand-book-1-1024_cr2.jpg",
                Address = "Nauky Ave. 14, Kharkiv",
                Telephone = "+380 (057) 702-18-07",
                Country = "Ukraine",
                Currency = "UAH",   
                Website = "https://nure.ua",
                Description = "Kharkiv National University of Radio Electronics (NURE) is one of the oldest technical universities in Ukraine established in 1930. It is a unique and a leading University of the technical profile, focused on the study of IT and innovative technologies, combining education and research, harmoniously integrating engineering and IT with other disciplines. NURE has the strong research and education abilities in electronics, telecommunications and computer technologies. NURE is an ambitious, innovative and modern University, oriented on studying of the real world. One of the University’s aims is to integrate into the international, particularly European, scientific and educational space. The University has 8 faculties, 33 full-time departments, Faculty for Foreign Students, Institute for Advanced Studies and NURE IT Academy. The University actively implements academic mobility programs, internships abroad for students, postgraduates, scientific and faculty staff. About 100 Doctors of Sciences, Professors, 350 PhD, Associate Professors work at the University. There are doctoral studies, postgraduate study in 17 specialties, 8 special councils for defending dissertations. Six periodic scientific journals are published at NURE. The high-tech library system has more than 1.5 million paper copies and access to the most well-known electronic databases. The campus includes 10 educational buildings and 8 dormitories, sports facilities, cafes, dining rooms, medical offices, recreation areas. Students from over 50 countries studies at the University in Ukrainian, Russian and English. We maintain the balance of research and education and encourage open mind; we adhere to the principles of tolerance and multi-culture. We offer an unmatched opportunity to get the combination of theoretical knowledge and practical experience. Everything we do in NURE from the point of view of innovations, academic mobility, cooperation with business and industry is aimed to a future success of the students in a real life.",
                MissionStatement = "Kharkiv National University of Radio Electronics, NURE, is one of the most distinctly profiled universities in Ukraine, where applied IT and innovation for sustainable are in focus. NURE has the vision to conduct education and research in which engineering and IT can be integrated with other disciplines. Everything we do at NURE has three distinct perspectives: innovation, sustainability and in real life, which means collaboration and exchange with both the business and industry as well as society. Vision. We are a modern scientific and educational hub that provides practical knowledge in close cooperation with business and through project-based training. We provide affordable education, preparing professionals in the digital world. Mission. To create highly qualified professionals for successful digital transformation of Ukraine as a part of the whole world.",
                Region = "Kharkivska oblast",
                InstitutionalPerimeterInclusions = @"https://nure.ua/en/branch/scientific-research-part-srp/srp-structure/pilot-plant-of-nure",
                InstitutionalPerimeterExclusions = "https://nure.ua/en/science-park-synergy"
            });
            _context.SaveChanges();
        }
    }
}