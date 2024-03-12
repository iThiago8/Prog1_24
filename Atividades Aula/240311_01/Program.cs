// OPERADORES

int i_A = 3;
int i_B = i_A++;

WriteLine($"A é {i_A}, b é {i_B}");

int i_C = 3;
int i_D = ++i_C;

WriteLine($"C é {i_C}, d é {i_D}");

int p = 6;
p += 3; //Equivalente a p = p + 3;
p -= 3; //Equivalente a p = p + 3;
p *= 3; //Equivalente a p = p + 3;
p /= 3; //Equivalente a p = p + 3;

//Operadores lógicos

bool b_A = true;
bool b_B = false;
WriteLine($"AND | b_A   | b_B ");
WriteLine($"b_A | {b_A & b_A,-5} | {b_A & b_B,-5} ");
WriteLine($"b_B | {b_B & b_A,-5} | {b_B & b_B,-5} ");
WriteLine();
WriteLine($"OR  | b_A   | b_B ");
WriteLine($"b_A | {b_A | b_A,-5} | {b_A | b_B,-5} ");
WriteLine($"b_B | {b_B | b_A,-5} | {b_B | b_B,-5} ");
WriteLine();
WriteLine($"XOR | b_A   | b_B ");
WriteLine($"b_A | {b_A ^ b_A,-5} | {b_A ^ b_B,-5} ");
WriteLine($"b_B | {b_B ^ b_A,-5} | {b_B ^ b_B,-5} ");