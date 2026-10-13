

using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        while (true)
        {
            Console.WriteLine("\n========== LAB 1 - MENU BAI TAP ==========");
            Console.WriteLine("1. Nhap thong tin ca nhan");
            Console.WriteLine("2. Tinh toan hinh tru");
            Console.WriteLine("3. Xep loai ket qua hoc tap");
            Console.WriteLine("4. Menu tinh tong va bang cuu chuong 7");
            Console.WriteLine("5. Xu ly ngoai le phep chia");
            Console.WriteLine("6. Giai phuong trinh bac hai");
            Console.WriteLine("7. Thong ke day so nguyen");
            Console.WriteLine("8. Liet ke so nguyen to");
            Console.WriteLine("9. Doc so tu 0 den 99");
            Console.WriteLine("10. Ve hinh bang ky tu *");
            Console.WriteLine("0. Thoat");
            Console.Write("Chon bai muon chay: ");

            if (!int.TryParse(Console.ReadLine(), out int chon))
            {
                Console.WriteLine("Lua chon khong hop le!");
                continue;
            }

            switch (chon)
            {
                case 1: Bai1(); break;
                case 2: Bai2(); break;
                case 3: Bai3(); break;
                case 4: Bai4(); break;
                case 5: Bai5(); break;
                case 6: Bai6(); break;
                case 7: Bai7(); break;
                case 8: Bai8(); break;
                case 9: Bai9(); break;
                case 10: Bai10(); break;
                case 0:
                    Console.WriteLine("Ket thuc chuong trinh.");
                    return;
                default:
                    Console.WriteLine("Lua chon khong hop le!");
                    break;
            }
        }
    }

    // Bai 1: Nhap thong tin ca nhan
    static void Bai1()
    {
        Console.Write("Nhap ho va ten: ");
        string hoTen = Console.ReadLine() ?? "";

        Console.Write("Nhap nam sinh: ");
        if (!int.TryParse(Console.ReadLine(), out int namSinh) ||
            namSinh < 1 || namSinh > DateTime.Now.Year)
        {
            Console.WriteLine("Nam sinh khong hop le!");
            return;
        }

        int tuoi = DateTime.Now.Year - namSinh;
        Console.WriteLine("Ho ten: " + hoTen);
        Console.WriteLine("Tuoi gan dung: " + tuoi);
    }

    // Bai 2: Dien tich xung quanh va the tich hinh tru
    static void Bai2()
    {
        Console.Write("Nhap ban kinh r: ");
        if (!double.TryParse(Console.ReadLine(), out double r) || r <= 0)
        {
            Console.WriteLine("Ban kinh khong hop le!");
            return;
        }

        Console.Write("Nhap chieu cao h: ");
        if (!double.TryParse(Console.ReadLine(), out double h) || h <= 0)
        {
            Console.WriteLine("Chieu cao khong hop le!");
            return;
        }

        double dienTich = 2 * Math.PI * r * h;
        double theTich = Math.PI * r * r * h;
        Console.WriteLine("Dien tich xung quanh = {0:F2}", dienTich);
        Console.WriteLine("The tich = {0:F2}", theTich);
    }

    // Bai 3: Xep loai hoc tap
    static void Bai3()
    {
        Console.Write("Nhap diem (0-10): ");
        if (!double.TryParse(Console.ReadLine(), out double diem) ||
            diem < 0 || diem > 10)
        {
            Console.WriteLine("Diem khong hop le!");
            return;
        }

        if (diem >= 9)
            Console.WriteLine("Xuat sac");
        else if (diem >= 8)
            Console.WriteLine("Gioi");
        else if (diem >= 6.5)
            Console.WriteLine("Kha");
        else if (diem >= 5)
            Console.WriteLine("Trung binh");
        else
            Console.WriteLine("Yeu");
    }

    // Bai 4: Menu tinh tong 1..n va bang cuu chuong 7
    static void Bai4()
    {
        while (true)
        {
            Console.WriteLine("\n--- BAI 4 ---");
            Console.WriteLine("1. Tinh tong tu 1 den n");
            Console.WriteLine("2. In bang cuu chuong 7");
            Console.WriteLine("0. Quay lai menu chinh");
            Console.Write("Chon: ");

            if (!int.TryParse(Console.ReadLine(), out int chon))
            {
                Console.WriteLine("Lua chon khong hop le!");
                continue;
            }

            switch (chon)
            {
                case 1:
                    Console.Write("Nhap n (n >= 1): ");
                    if (!int.TryParse(Console.ReadLine(), out int n) || n < 1)
                    {
                        Console.WriteLine("n khong hop le!");
                        break;
                    }

                    long tong = 0;
                    for (int i = 1; i <= n; i++)
                        tong += i;

                    Console.WriteLine("Tong tu 1 den {0} = {1}", n, tong);
                    break;

                case 2:
                    for (int i = 1; i <= 10; i++)
                        Console.WriteLine("7 x {0} = {1}", i, 7 * i);
                    break;

                case 0:
                    return;

                default:
                    Console.WriteLine("Lua chon khong hop le!");
                    break;
            }
        }
    }

    // Bai 5: Xu ly loi khi nhap va chia
    static void Bai5()
    {
        try
        {
            Console.Write("Nhap a (so nguyen): ");
            int a = int.Parse(Console.ReadLine() ?? "");

            Console.Write("Nhap b (so nguyen): ");
            int b = int.Parse(Console.ReadLine() ?? "");

            if (b == 0)
            {
                Console.WriteLine("Khong the chia cho 0!");
                return;
            }

            Console.WriteLine("a / b = " + ((double)a / b));
        }
        catch (FormatException)
        {
            Console.WriteLine("Du lieu phai la so nguyen!");
        }
        catch (OverflowException)
        {
            Console.WriteLine("So nhap vao qua lon hoac qua nho!");
        }
        finally
        {
            Console.WriteLine("Ket thuc phep tinh.");
        }
    }

    // Bai 6: Giai phuong trinh ax^2 + bx + c = 0
    static void Bai6()
    {
        Console.Write("Nhap a: ");
        if (!double.TryParse(Console.ReadLine(), out double a))
        {
            Console.WriteLine("Gia tri a khong hop le!");
            return;
        }

        Console.Write("Nhap b: ");
        if (!double.TryParse(Console.ReadLine(), out double b))
        {
            Console.WriteLine("Gia tri b khong hop le!");
            return;
        }

        Console.Write("Nhap c: ");
        if (!double.TryParse(Console.ReadLine(), out double c))
        {
            Console.WriteLine("Gia tri c khong hop le!");
            return;
        }

        if (a == 0)
        {
            if (b == 0)
            {
                Console.WriteLine(c == 0
                    ? "Phuong trinh vo so nghiem"
                    : "Phuong trinh vo nghiem");
            }
            else
            {
                Console.WriteLine("Phuong trinh co nghiem x = {0:F2}", -c / b);
            }
            return;
        }

        double delta = b * b - 4 * a * c;

        if (delta < 0)
            Console.WriteLine("Phuong trinh vo nghiem thuc");
        else if (delta == 0)
            Console.WriteLine("Phuong trinh co nghiem kep x = {0:F2}", -b / (2 * a));
        else
        {
            double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
            Console.WriteLine("x1 = {0:F2}", x1);
            Console.WriteLine("x2 = {0:F2}", x2);
        }
    }

    // Bai 7: Thong ke day so nguyen
    static void Bai7()
    {
        Console.Write("Nhap so luong phan tu n: ");
        if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
        {
            Console.WriteLine("n phai la so nguyen duong!");
            return;
        }

        long tong = 0;
        int soChan = 0;
        int max = int.MinValue;
        int min = int.MaxValue;

        for (int i = 1; i <= n; i++)
        {
            Console.Write("Nhap so thu {0}: ", i);
            if (!int.TryParse(Console.ReadLine(), out int x))
            {
                Console.WriteLine("Gia tri khong hop le. Hay chay lai bai 7.");
                return;
            }

            tong += x;
            if (x > max) max = x;
            if (x < min) min = x;
            if (x % 2 == 0) soChan++;
        }

        Console.WriteLine("Tong = " + tong);
        Console.WriteLine("Trung binh = {0:F2}", (double)tong / n);
        Console.WriteLine("So lon nhat = " + max);
        Console.WriteLine("So nho nhat = " + min);
        Console.WriteLine("So luong so chan = " + soChan);
    }

    // Bai 8: Liet ke so nguyen to den n
    static bool LaSoNguyenTo(int n)
    {
        if (n < 2) return false;

        for (int i = 2; i <= n / i; i++)
        {
            if (n % i == 0) return false;
        }

        return true;
    }

    static void Bai8()
    {
        Console.Write("Nhap n: ");
        if (!int.TryParse(Console.ReadLine(), out int n) || n < 2)
        {
            Console.WriteLine("Hay nhap n >= 2!");
            return;
        }

        Console.WriteLine("Cac so nguyen to tu 2 den {0}:", n);
        for (int i = 2; i <= n; i++)
        {
            if (LaSoNguyenTo(i))
                Console.Write(i + " ");
        }
        Console.WriteLine();
    }

    // Bai 9: Doc so tu 0 den 99
    static string DocChuSo(int n)
    {
        switch (n)
        {
            case 0: return "khong";
            case 1: return "mot";
            case 2: return "hai";
            case 3: return "ba";
            case 4: return "bon";
            case 5: return "nam";
            case 6: return "sau";
            case 7: return "bay";
            case 8: return "tam";
            case 9: return "chin";
            default: return "";
        }
    }

    static string DocSo(int n)
    {
        if (n < 10) return DocChuSo(n);
        if (n == 10) return "muoi";
        if (n < 20)
        {
            int donVi = n % 10;
            if (donVi == 5) return "muoi lam";
            if (donVi == 0) return "muoi";
            return "muoi " + DocChuSo(donVi);
        }

        int chuc = n / 10;
        int donViHangDonVi = n % 10;
        string ketQua = DocChuSo(chuc) + " muoi";

        if (donViHangDonVi == 1)
            ketQua += " mot";
        else if (donViHangDonVi == 5)
            ketQua += " lam";
        else if (donViHangDonVi != 0)
            ketQua += " " + DocChuSo(donViHangDonVi);

        return ketQua;
    }

    static void Bai9()
    {
        Console.Write("Nhap so tu 0 den 99: ");
        if (!int.TryParse(Console.ReadLine(), out int n) || n < 0 || n > 99)
        {
            Console.WriteLine("So khong hop le!");
            return;
        }

        Console.WriteLine("Cach doc: " + DocSo(n));
    }

    // Bai 10: Ve tam giac dac, tam giac rong, hinh vuong rong
    static void Bai10()
    {
        while (true)
        {
            Console.WriteLine("\n--- BAI 10 ---");
            Console.WriteLine("1. Tam giac vuong dac");
            Console.WriteLine("2. Tam giac vuong rong");
            Console.WriteLine("3. Hinh vuong rong");
            Console.WriteLine("0. Quay lai menu chinh");
            Console.Write("Chon: ");

            if (!int.TryParse(Console.ReadLine(), out int chon))
            {
                Console.WriteLine("Lua chon khong hop le!");
                continue;
            }

            if (chon == 0) return;
            if (chon < 1 || chon > 3)
            {
                Console.WriteLine("Lua chon khong hop le!");
                continue;
            }

            Console.Write("Nhap kich thuoc n: ");
            if (!int.TryParse(Console.ReadLine(), out int n) || n < 1)
            {
                Console.WriteLine("Kich thuoc khong hop le!");
                continue;
            }

            switch (chon)
            {
                case 1:
                    for (int i = 1; i <= n; i++)
                    {
                        for (int j = 1; j <= i; j++)
                            Console.Write("*");
                        Console.WriteLine();
                    }
                    break;

                case 2:
                    for (int i = 1; i <= n; i++)
                    {
                        for (int j = 1; j <= i; j++)
                        {
                            if (j == 1 || j == i || i == n)
                                Console.Write("*");
                            else
                                Console.Write(" ");
                        }
                        Console.WriteLine();
                    }
                    break;

                case 3:
                    for (int i = 1; i <= n; i++)
                    {
                        for (int j = 1; j <= n; j++)
                        {
                            if (i == 1 || i == n || j == 1 || j == n)
                                Console.Write("*");
                            else
                                Console.Write(" ");
                        }
                        Console.WriteLine();
                    }
                    break;
            }
        }
    }
}
