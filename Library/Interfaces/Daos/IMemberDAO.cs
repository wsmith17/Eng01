using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Library.Interfaces.Entities;
using Library.Interfaces.Helpers;

namespace Library.Interfaces.Daos
{
    interface IMemberDAO
    {
        IMember addMember(string firstName, string lastName, string ContactPhone, string emailAddress);

        IMember getMemberByID(int id);

        List<IMember> listMembers();

        List<IMember> findMembersByLastName(string lastName);

        List<IMember> findMembersByEmailAddress(string emailAddress);

        List<IMember> findMembersByNames(string firstName, string lastName);

    }
}
