using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace cbchot_bc
{
    class common
    {
    }

    class owner
    {
        string owner_name;
        string owner_id;
        ArrayList video_list;
    }

    class video
    {
        string video_name;
        string video_describe;
        string video_id;
        string video_etag;
        int length;

    }

    class play_record
    {
        string client_id;
        string v_id;
        string start_dt;
        string stop_dt;
    }


}
