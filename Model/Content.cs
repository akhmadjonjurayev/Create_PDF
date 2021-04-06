using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Create_PDF.Model
{
    public static class GetValue
    {
        public static string GetHTML()
        {
            return        @"<html>
                           <head></head>
                           <body>
                                   <table>
                                    <tr>
                                   <th>Ismi</th> 
                                   <th>Familyasi</th>
                                   <th>Jinsi</th>
                                   <th>Kursi</th>
                                   <th>yonalishi</th>
                                   </tr>
                                   <tr>
                                   <th>Yahyo</th>
                                   <th>Abdualimov</th>
                                   <th>Erkak</th>
                                   <th>3-kurs</th>
                                   <th>Bank</th>
                                   </tr>
                                   <tr>
                                   <th>Ahmadjon</th>
                                   <th>Jo'rayev</th>
                                   <th>Erkak</th>
                                   <th>3-kurs</th>
                                   <th>Backend</th>
                                   </tr>
                                   <tr>
                                   <th>Najmiddin</th>
                                   <th>Nazirov</th>
                                   <th>Erkak</th>
                                   <th>3-kurs</th>
                                   <th>Frontend</th>
                                   </tr>
                                   </table>
                           </body>
                         </html>";
        }
    }
}
