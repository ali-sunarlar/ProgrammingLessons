import 'package:flutter/material.dart';

void main() {
  runApp(const MyApp());
}

// ParentWidget manages the state for TapboxB.
//Ebeveyn Bileşenin Durumu Yönetmesi

//------------------------ ParentWidget --------------------------------

class ParentWidget extends StatefulWidget {
  const ParentWidget({super.key});

  @override
  State<ParentWidget> createState() => _ParentWidgetState();
}

class _ParentWidgetState extends State<ParentWidget> { //Asil durumunu active ve pasif yapan budur. Digerleri activelikten etkilenirler
  bool _active = false;

  void _handleTapboxChanged(bool newValue) { //metod tanimlanmis
    setState(() {
      _active = newValue;
    });
  }

  @override
  Widget build(BuildContext context) {//TapboxB'in cizimi yapiliyor
    return SizedBox(
      child: TapboxB(
        active: _active,
        onChanged: _handleTapboxChanged,
      ),
    );
  }
}

//------------------------- TapboxB ----------------------------------

class TapboxB extends StatelessWidget { //Kendi icerisinde set state barindirmayacagindan stateless olarak tanimlaniyor. Kendisi ekran degisimi icin bir trigger veya tetikleme barindirmayacak
  const TapboxB({
    super.key,
    this.active = false,
    required this.onChanged, //ustteki fonksiyondan ekran degisimi icin parametre aliyor
  });

  final bool active;
  final ValueChanged<bool> onChanged;

  void _handleTap() {
    onChanged(!active);
  }

  @override
  Widget build(BuildContext context) {
    return GestureDetector(
      onTap: _handleTap,
      child: Container(
        width: 200,
        height: 200,
        decoration: BoxDecoration(
          color: active ? Colors.lightGreen[700] : Colors.grey[600],
        ),
        child: Center(
          child: Text(
            active ? 'Active' : 'Inactive',
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
          child: ParentWidget(),
        ),
      ),
    );
  }
}