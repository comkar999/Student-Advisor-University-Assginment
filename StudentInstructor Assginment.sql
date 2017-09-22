alter table Student
alter column StudentCourse nvarchar(50)
sp_helptext Student

insert into Student values('Roy', 'Boston','Data Structures',2)

update Student set AdvisorId=3 where StudentName='Villarta' 
select @@SERVERNAME

select * from information_Schema.columns where table_name = 'Student'

select * from Student
select * from Advisor
create table Advisor
(
AdvisorId int primary key identity(1,1),
AdvisorName nvarchar(50) 
)

create procedure spStudentDetails
as
begin

select s.StudentId,s.StudentName,s.StudentAddress,s.StudentCourse,a.AdvisorName 
from Student s
join Advisor a
on s.AdvisorId=a.AdvisorId

end



insert into Advisor values('Sara')

)