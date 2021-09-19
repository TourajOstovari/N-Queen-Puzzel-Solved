namespace NQueen2021
{
    interface IChecker
    {
        bool Sotoni(byte[,] Pz); // Columns Vertical mode
        bool Zarbdari(byte[,] Pz); // X mode 
    }
    public class Checker : IChecker
    {
        public bool Sotoni(byte[,] Pz)
        {
            for (int y = 0; y < Program.SizeXY; y++)
            {
                for (int x = 0; x < Program.SizeXY; x++)
                {
                    if (Pz[y, x] == 1)
                    {
                        if (y == 0)
                        {
                            { // Checks Columns Vertical Mode 1
                                for (int i = (y + 1); i < Program.SizeXY; i++)
                                {
                                    if (Pz[i, x] == 1)
                                    {
                                        return true;
                                    }
                                }
                            }
                        }
                        if (y > 0 && y < (Program.SizeXY - 1))
                        {
                            { // Checks Columns Vertical Mode 1
                                for (int i = (y + 1); i < Program.SizeXY; i++)
                                {
                                    if (Pz[i, x] == 1)
                                    {
                                        return true;
                                    }
                                }
                            }
                            { // Checks Columns Vertical Mode 2
                                for (int i = (y - 1); i > 0; i--)
                                {
                                    if (Pz[i, x] == 1)
                                    {
                                        return true;
                                    }
                                }
                            }
                        }
                        if (y == (Program.SizeXY - 1))
                        {
                            { // Checks Columns Vertical Mode 2
                                for (int i = (y - 1); i > 0; i--)
                                {
                                    if (Pz[i, x] == 1)
                                    {
                                        return true;
                                    }
                                }
                            }
                        }
                    }
                }

            }

            return false;
        }

        public bool Zarbdari(byte[,] Pz)
        {
            for (int y = 0; y < Program.SizeXY; y++)
            {
                for (int x = 0; x < Program.SizeXY; x++)
                {
                    if (Pz[y, x] == 1)
                    {
                        if (y == 0)
                        {

                            { // Checks X mode    - FIXED
                                int x2 = (x + 1);
                                for (int y2 = (y + 1); y2 < Program.SizeXY; y2++)
                                {
                                    
                                    {
                                        if (x2 == Program.SizeXY)
                                            break;
                                        if (Pz[y2, x2] == 1)
                                        {

                                            return true;
                                        }
                                        if ((x2 + 1) >= Program.SizeXY)
                                        {
                                            y2 = Program.SizeXY;
                                            break;
                                        }
                                        else
                                        {
                                            x2++;
                                        }

                                    }
                                }
                            }
                            {  // Checks X mode    -  FIXED
                                int x2 = (x - 1);
                                for (int y2 = (y + 1); y2 < Program.SizeXY; y2++)
                                {
                                    {
                                        if (x2 < 0)
                                        {
                                            break;
                                        }
                                        if (Pz[y2, x2] == 1)
                                        {
                                            return true;
                                        }
                                        if (x2 > 0)
                                        {
                                            --x2;
                                        }
                                        if (x2 <= 0)
                                        {
                                            break;
                                        }

                                    }
                                }
                            }

                        }
                    }
                    if (y > 0 && Pz[y, x] == 1)
                    {


                        { // Checks X mode    - FIXED
                            int x2 = (x + 1);
                            for (int y2 = (y + 1); y2 < Program.SizeXY; y2++)
                            {

                                {
                                    if (x2 == Program.SizeXY)
                                        break;
                                    if (Pz[y2, x2] == 1)
                                    {

                                        return true;
                                    }
                                    if ((x2 + 1) >= Program.SizeXY)
                                    {
                                        y2 = Program.SizeXY;
                                        break;
                                    }
                                    else
                                    {
                                        x2++;
                                    }

                                }
                            }
                        }
                        {  // Checks X mode    -  FIXED
                            int x2 = (x - 1);
                            for (int y2 = (y + 1); y2 < Program.SizeXY; y2++)
                            {
                                {
                                    if (x2 < 0)
                                    {
                                        break;
                                    }
                                    if (Pz[y2, x2] == 1)
                                    {
                                        return true;
                                    }
                                    if ((x2-1) >= 0)
                                    {
                                        --x2;
                                    }
                                    if (x2 < 0)
                                    {
                                        break;
                                    }
                                    
                                }
                            }
                        }




                        { // Checks X mode
                            int x2 = (x - 1);
                            for (int y2 = (y - 1); y2 >= 0; y2--)
                            {

                                {
                                    if (x2 < 0)
                                    {
                                        break;
                                    }
                                    if (Pz[y2, x2] == 1)
                                    { 
                                        return true;
                                    }
                                }
                                if (x2 > 0)
                                    x2--;
                                if ((x2-1) < 0 || (y2-1) < 0)
                                    break;
                            }
                        }
                        {  // Checks X mode
                            int x2 = (x + 1);
                            for (int y2 = (y - 1); y2 > 0;y2--)
                            {
                                
                                {
                                    if (x2 == Program.SizeXY)
                                        break;
                                    if (Pz[y2, x2] == 1)
                                    { 
                                        return true;
                                    }
                                    if (x2 < Program.SizeXY)
                                        x2++;
                                    if (x2 >= Program.SizeXY)
                                        break;
                                }
                            }
                        }
                    }
                }
            }
            return false;
        }
    }
}
