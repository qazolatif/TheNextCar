# The Next Car
Aplikasi ini digunakan untuk mobil yang memiliki teknologi masa depan yang berfungsi untuk memudahkan pengguna dalam menggunakan mobil.
## Scope & Functionalities
* User dapat menekan tombol untuk menyalakan atau mematikan mesin.
* User dapat menekan tombol untuk membuka atau menutup pintu mobil.
* User dapat menekan tombol untuk mengunci atau membuka kunci pintu mobil.
* User dapat menekan tombol untuk menghidupkan atau mematikan power.
* User dapat mengetahui apakah mesin dapat dihidupkan dengan syarat-syarat tertentu yaitu pintu harus ditutup, pintu harus dikunci dan power harus hidup.
## How does it works?
1. Class diagram dari projek ini
![Class Diagram](assets/classDiagram)
2. Kegunaan `DoorController.cs` adalah menampung fungsi mengontrol pintu mobil seperti:
* **close()** = fungsi untuk menutup pintu mobil
* **open()** = fungsi untuk membuka pintu mobil
* **activateLock()** = fungsi untuk mengunci pintu mobil
* **unlock()** = fungsi untuk membuka kunci pintu mobil
* **isClosed()** = fungsi untuk mengetahui apakah pintu mobil sudah dikunci atau belum.
* **isLocked()** = fungsi untuk mengetahui apakah pintu mobil sudah ditutup atau belum.
3. Kegunaan model `Door.cs` adalah untuk menampung variabel berupa:
* **closed** = variabel untuk menutup pintu mobil
* **locked** = variabel untuk mengunci pintu mobil
4. Kegunaan interface OnDoorChanged adalah sebagai _abstraction_ agar ketika kita memanggil fungsi di class `DoorController.cs`, kita hanya perlu memanggil fungsi abstraksinya saja.