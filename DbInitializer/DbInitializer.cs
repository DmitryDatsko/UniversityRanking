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
                    LogoUrl = @"https://tse1.mm.bing.net/th?id=OIG2.LDtcZbp9F.Fkxn48kukI&pid=ImgGn",
                    Title = "Academic reputation",
                    Description = "The Academic Reputation page highlights the university's standing in the academic community. It showcases rankings, research output, and notable faculty achievements. This page also includes information on prestigious awards and recognitions received by the university. Detailed statistics on publication citations and collaborative projects are featured. Testimonials from academic peers and alumni further emphasize the institution's reputation. This comprehensive overview underscores the university's commitment to academic excellence and innovation.",
                },
                new()
                {
                    LogoUrl = @"https://tse3.mm.bing.net/th/id/OIG3.gGxBjRspfINeQVTbc8Xc?pid=ImgGn",
                    Title = "Employer Reputation",
                    Description = "The Employer Reputation page underscores the university's strong connections with top employers globally. It features data on graduate employment rates and notable employer partnerships. This page also highlights testimonials from employers who regularly hire graduates from the university. Information on career fairs, internships, and co-op programs is provided. Additionally, it includes statistics on alumni success and career progression. This detailed overview demonstrates the university's commitment to producing highly employable graduates.",
                },
                new()
                {
                    Title = "Citation",
                    LogoUrl = @"https://tse2.mm.bing.net/th/id/OIG1.tupm1ddtR1IbfMC.Tscv?pid=ImgGn",
                    Description = "The Faculty Citations page highlights the research impact of the university's faculty members. It includes detailed statistics on citation counts and influential publications. This page showcases prominent research projects and areas of expertise within the faculty. Information on interdisciplinary collaborations and funded research initiatives is also featured. Testimonials from peers and industry leaders emphasize the significance of the faculty's contributions. This comprehensive overview demonstrates the faculty's influence and leadership in their respective fields.",
                },
                new()
                {
                    Title = "Employment Result",
                    LogoUrl = @"https://tse2.mm.bing.net/th/id/OIG4.syCTxzl2_BugaMeV.6iX?pid=ImgGn",
                    Description = "The Employment Results page provides detailed insights into the career outcomes of the university's graduates. It features statistics on employment rates, sectors, and average starting salaries. This page also highlights successful alumni stories and notable career achievements. Information on the university's career services and support programs is included. Additionally, it showcases data on graduate school placements and professional certifications. This comprehensive overview demonstrates the university's effectiveness in preparing students for successful careers.",
                },
                new()
                {
                    Title = "Faculty Student Ratio",
                    LogoUrl = @"https://tse1.mm.bing.net/th/id/OIG1.ebYee3njj0iPVoKMDKMg?pid=ImgGn",
                    Description = "The Faculty-Student Ratio page highlights the personalized educational experience offered at the university. It features detailed statistics on the ratio of faculty members to students. This page emphasizes the benefits of small class sizes and individualized attention. Information on faculty accessibility and mentorship programs is also included. Testimonials from students and alumni underscore the positive impact of close faculty interactions. This comprehensive overview illustrates the university's commitment to providing a supportive and engaging learning environment.",
                },
                new()
                {
                    Title = "International Teachers Ratio",
                    LogoUrl = @"https://tse3.mm.bing.net/th/id/OIG3.uzh1tfnkg7Y2wWrKmhxp?pid=ImgGn",
                    Description = "The International Teachers Ratio page showcases the diverse faculty composition at the university. It provides statistics on the percentage of faculty members from international backgrounds. This page emphasizes the enriching experience of learning from educators with diverse cultural perspectives. Information on faculty exchange programs and international collaborations is highlighted. Additionally, it includes testimonials from students and faculty members about the benefits of a multicultural teaching environment. This comprehensive overview underscores the university's commitment to global engagement and academic excellence.",
                },
                new()
                {
                    Title = "Foreign Student Ratio",
                    LogoUrl = @"https://tse2.mm.bing.net/th/id/OIG3.TJWCS3uwK.xlEovaibTJ?pid=ImgGn",
                    Description = "The Foreign Student Ratio page highlights the international diversity within the university's student body. It provides statistics on the percentage of students from foreign countries. This page emphasizes the global learning environment and cultural exchange opportunities available to all students. Information on international student support services and multicultural events is included. Additionally, it features testimonials from current and past international students sharing their experiences. This comprehensive overview illustrates the university's commitment to fostering a welcoming and inclusive campus community.",
                },
                new()
                {
                    Title = "Research Network",
                    LogoUrl = @"https://tse2.mm.bing.net/th/id/OIG4._FA4euGOWd4Nnq6zhlJF?pid=ImgGn",
                    Description = "The Global Education Research Network (GERN) is a collaborative initiative aimed at fostering international cooperation in the field of education research. Our mission is to promote knowledge exchange, facilitate joint research projects, and enhance the global impact of educational research. We believe in the power of shared knowledge and collaboration to address the complex challenges of education in the 21st century.",
                },
                new()
                {
                    Title = "Student Stability",
                    LogoUrl = @"https://tse4.mm.bing.net/th/id/OIG2.T.IuNKkNIll51oNq2ZNA?pid=ImgGn",
                    Description = "The Student Stability Amid Conflict page sheds light on the resilience of students facing adversity in their home countries. It presents statistics on the number of students remaining in their countries despite ongoing conflict. This page emphasizes the university's support mechanisms for students affected by war, including counseling services and humanitarian aid initiatives. Information on student-led advocacy efforts and community support networks is also featured. Additionally, it includes testimonials from students sharing their stories of perseverance and determination. This comprehensive overview showcases the university's commitment to providing a safe and supportive environment for all students, especially during challenging times.",
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