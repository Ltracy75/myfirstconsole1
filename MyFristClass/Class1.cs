using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstClass
    {
    internal class TqlStudent
        {
        private static int NextId = 1;
        public int Id { get; set; } =0;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public int YearsOfService { get; set; } = 0;
        public Assessment? GitGithubAssessment { get; set; } = null;
        public Assessment? GitGitSQL { get; set; } = null;
        public Assessment? GitGitCSharp { get; set; } = null;
        public Assessment? GitGitJavaScript { get; set; } = null;
        public Assessment? GitGitAngular { get; set; } = null;


        public string FullName()
            {
            return $"{this.FirstName} {this.LastName}";
            }
            
        public string Dad()
            {
            var msg = $"{Id}:{FullName()} has {YearsOfService} year{(YearsOfService > 1 ? "s" : "")} at TQL";
            if (GitGithubAssessment is not null)
                {
                msg = msg + $"\nAssessment {GitGithubAssessment!.Topic}, Points {GitGithubAssessment.Points}";
                }
            
            if (GitGitSQL is not null)
                {
                msg = msg + $"\nAssessment {GitGitSQL!.Topic}, Points {GitGitSQL.Points}";
                }
            if (GitGitCSharp is not null)
                {
                msg = msg + $"\nAssessment {GitGitCSharp!.Topic}, Points {GitGitCSharp.Points}";
                }
            if (GitGitJavaScript is not null)
                {
                msg = msg + $"\nAssessment {GitGitJavaScript!.Topic}, Points {GitGitJavaScript.Points}";
                }
            if (GitGitAngular is not null)
                {
                msg = msg + $"\nAssessment {GitGitAngular!.Topic}, Points {GitGitAngular.Points}";
                }
            return msg;
            }
        public void HappyAnni()
            {
            YearsOfService++;
            }
        public TqlStudent(string firstname, string lastname, int Years)
            {
            FirstName = firstname;
                        LastName = lastname;
            YearsOfService = Years;
            Id = NextId++;
            }
        public TqlStudent() 
            {
            Id = NextId++;
         
            }

        }
    }
