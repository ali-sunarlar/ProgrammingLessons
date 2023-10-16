import 'package:flutter/material.dart';

void main() {
  runApp(const MyApp());
}
// TapboxA manages its own state.
//Kendi durumunu yoneten Arayuz Bileseni

//------------------------- TapboxA ----------------------------------

class TapboxA extends StatefulWidget { //Statefull'dan miras aliniyor
  const TapboxA({super.key}); //basit bir yapilandirici fonksiyonu var

  @override
  State<TapboxA> createState() => _TapboxAState(); //TapboxA sinifinin bir ornegini olusturuyor
}

class _TapboxAState extends State<TapboxA> { //TapboxA'nin durumlarini kontrol edilmesi için bir sinif olusturuluyor
  bool _active = false; //butonun durumunu kontrol edilmesi boolen tipinde degisken olusturulor

  void _handleTap() {
    setState(() { //Arayuz tekrardan olusturulmasi icin tanimlaniyor
      _active = !_active; //True ise false false ise true'ya ceviren bir fonk
    });
  }

  @override
  Widget build(BuildContext context) {
    return GestureDetector( //kullanici etkileşimini yakalamak icin
      onTap: _handleTap,
      child: Container(
        width: 200,
        height: 200,
        decoration: BoxDecoration( //Arka plan rengi
          color: _active ? Colors.lightGreen[700] : Colors.grey[600],
        ),
        child: Center(
          child: Text(
            _active ? 'Active' : 'Inactive',
            style: const TextStyle(fontSize: 32, color: Colors.white),
          ),
        ),
      ),
    );
  }
}

//------------------------- MyApp ----------------------------------

class MyApp extends StatelessWidget {
  const MyApp({super.key});

  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      title: 'Flutter Demo',
      home: Scaffold(
        appBar: AppBar(
          title: const Text('Flutter Demo'),
        ),
        body: const Center(
          child: TapboxA(),
        ),
      ),
    );
  }
}