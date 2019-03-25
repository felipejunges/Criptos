# Criptos

Aplicativo em .Net Core de exemplo das libs SCrypt e BCrypt.

## Implementação

Esse projeto implementa uma interface, duas classes que a extendem e um exemplo de uso destas.

```
string CreateHash(string senha);
bool Check(string senha, string hash);
```

## Exemplo

```
CryptLib bCrypt = new BCryptLib();
string senhaBCrypt = bCrypt.CreateHash(senha);
bool bCryptOK = bCrypt.Check(senha, senhaBCrypt)

CryptLib sCrypt = new SCryptLib();
string senhaSCrypt = sCrypt.CreateHash(senha);
bool sCryptOK = sCrypt.Check(senha, senhaSCrypt)
```

## Utiliza

* [SCrypt](https://github.com/viniciuschiele/scrypt) - A .NET implementation of scrypt password hash algorithm.
* [BCrypt](https://github.com/neoKushan/BCrypt.Net-Core) - A .net Core port of BCrypt.net
