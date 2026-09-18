# Pink Scientific Calculator App

Aplikasi kalkulator berbasis Windows Forms (C#) dilengkapi dengan fungsi aritmatika dasar, fitur kalkulator ilmiah (*scientific*), serta pencatatan riwayat perhitungan (*history*).

Aplikasi ini dibuat dengan menerapkan prinsip **Separation of Concerns** (SoC), seluruh logika perhitungan dipisahkan dari antarmuka pengguna (UI) ke dalam kelas *service* tersendiri (`CalculatorService.cs`).

---

## Preview Aplikasi
<img width="505" height="486" alt="Screenshot 2026-09-17 235829" src="https://github.com/user-attachments/assets/f26c1dc3-3569-4320-93f3-3bc54b194154" />

---

## Fitur Utama

- **Basic Arithmetic Operations**: Penjumlahan (`+`), Pengurangan (`-`), Perkalian (`*`), dan Pembagian (`/`).
- **Scientific Operations**:
  - Modulo (`mod`)
  - Pangkat ($y^x$) & Akar Pangkat ($^y\sqrt{x}$)
  - Logaritma dengan basis variabel ($\log_y x$)
  - Faktorial ($n!$)
  - Konstanta Matematika ($\pi$ dan $e$)
  - Pengelompokan Ekspresi dengan Kurung `(` dan `)`
- **Utility Functions**:
  - Clear (`C`)
  - Backspace (`⌫`) untuk menghapus satu karakter terakhir
  - Input Angka Desimal (`.`)
- **Calculation History**: Menampilkan riwayat perhitungan secara otomatis pada komponen `ListBox`.
- **Clean Architecture**: Logika matematika terpisah di dalam `CalculatorService.cs`.

---

## Struktur Proyek

- **`Form1.cs`**: Mengelola antarmuka pengguna (UI) dan menerima *event handler* dari tombol.
- **`CalculatorService.cs`**: Menyimpan seluruh logika matematis dan pemrosesan riwayat.
- **`Form1.Designer.cs`**: Mengatur tata letak dan konfigurasi komponen Form secara otomatis.

---

## Refleksi Mahasiswa

### 1. Apa fungsi `object sender` pada event handler?
`object sender` memicu (*trigger*) pada objek/kontrol UI. Pada aplikasi kalkulator ini, `sender` berisi tombol (`Button`) yang sedang diklik oleh pengguna. Dengan melakukan *type casting* `(Button)sender`, data properti dari tombol tersebut dapat diambil secara dinamis tanpa perlu membuat *event handler* terpisah untuk setiap tombol.

### 2. Mengapa semua tombol angka dapat memakai satu `NumberButton_Click`?
Karena logika pengolahan angka untuk tombol `0` sampai `9` identik, yaitu mengambil teks angka dari tombol yang diklik dan menambahkan/menempelkannya ke `textBox1`. Dengan memanfaatkan `object sender`, kita cukup membuat satu method `NumberButton_Click` lalu mengaitkan (*assign*) event `Click` seluruh tombol angka ke method tersebut. Hal ini menerapkan prinsip **DRY (Don't Repeat Yourself)** sehingga kode lebih efisien dan mudah dirawat.

### 3. Apa perbedaan `firstNumber`, `secondNumber`, dan `result`?
- **`firstNumber`**: Menyimpan nilai operand pertama yang diinputkan pengguna sebelum memilih operator aritmatika.
- **`secondNumber`**: Menyimpan nilai operand kedua yang diinputkan setelah operator dipilih dan sebelum menekan tombol sama dengan (`=`).
- **`result`**: Menyimpan hasil akhir dari operasi matematika yang dihitung oleh `CalculatorService`.

### 4. Mengapa pembagian dengan nol perlu divalidasi?
Secara matematis, pembagian dengan angka nol tidak terdefinisi (*undefined*). Jika pembagian nol dilakukan pada sistem tanpa validasi, program akan melempar *exception* (`DivideByZeroException`) yang dapat menyebabkan aplikasi mengalami *crash* mendadak. Validasi dilakukan untuk menangkap kondisi ini dan menampilkan pesan peringatan yang ramah penggunanya (*user-friendly*).

### 5. Bagaimana `try-catch` membantu menjaga aplikasi tetap stabil?
Blok `try-catch` berfungsi menangkap *runtime error* (seperti format input yang salah, pembagian dengan nol, atau kalkulasi faktorial angka negatif) sebelum error tersebut menghentikan eksekusi program. Ketika terjadi kesalahan di dalam blok `try`, alur program langsung berpindah ke blok `catch` untuk menampilkan pesan kesalahan menggunakan `MessageBox.Show()`, sehingga aplikasi tidak *force close* (*crash*) dan pengguna dapat melanjutkan penggunaan kalkulator dengan aman.

---

## Author
Developed by **Salsabila Hana Adniah**
NRP **5025251191**
Kelas **PBKK-C**
