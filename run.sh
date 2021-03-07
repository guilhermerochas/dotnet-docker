echo "Criando rede..."
docker network create minha-rede
echo "Rodando Backend...."
docker run --name server-backend -d -p 5001:5001 backend:1.0
echo "Rodando Banco de dados..."
docker run --name database -e POSTGRES_PASSWORD=123456 -e POSTGRES_DB=mydb -d -p 3400:5432 postgres:alpine
echo "Adicionando o Backend à rede..."
docker network connect minha-rede server-backend
echo "Adicionando o DB à rede..."
docker network connect minha-rede database