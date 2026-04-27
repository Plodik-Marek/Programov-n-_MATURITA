import * as citiesService from "../services/cities.services.js";

export async function getCities(req, res) {
  const cities = await citiesService.getCities();
  res.json(cities);
}

export async function getCity(req, res) {
  const city = await citiesService.getCity(req.params.id);
  res.json(city);
}


/* funguje to jako šablona každý controller, repositories, routes, services jsou podobné,
 každá tabulka musí mít svůj repository,controller,rutes,services

 CONTROLLER - slouží jako příjmač requestů a response, bere data (req), zavolá příslušnou sevice a pošle odpověď (res)

 SERVICES - obsahuje logiku, rozhoduje co se má stát, obsahuje výpočty, pravidla aplikace, volání více repozitářů

 ROUTES - definují URL endpointy a HTTP metody, přijimá požadavky a posílá je controlleru, takže jen mapují URL 
 
 toto dělá routes 
   https://mujeshop.cz   →  doména (server)
   /api                  →  prefix skupiny rout
   /users                →  resource
   /42                   →  parametr (:id)


 REPOSITORY - je to část kde se mluví s databází, takže CRUD, dotazy 

 HTTP Request
    ↓
  Route          → správná cesta
    ↓
  Controller     → zpracuje req/res
    ↓
  Service        → byznys logika
    ↓
  Repository     → databáze
    ↓
  (zpět nahoru)

*/