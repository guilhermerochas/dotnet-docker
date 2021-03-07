import service from '../services/service'

export default class ProductController{
    getAllPosts(){
        service.get('/todos').then((response) => {
            console.log(response);
            return JSON.parse(response);
        })
        .catch((err) => console.log(err));
    }
}