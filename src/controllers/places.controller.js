import * as placesService from "../services/places.services.js";

export async function getPlaces(req, res) {
  const places = await placesService.getPlaces();
  res.json(places);
}

export async function getPlace(req, res) {
  const place = await placesService.getPlace(req.params.id);
  res.json(place);
}

export async function addPlace(req, res) {
  const newPlace = {
    place: req.body.place,
    type: req.body.type,
    description: req.body.description,
    address: req.body.address,
    FK_city_id: req.body.FK_city_id,
  };

  await placesService.addPlace(newPlace);
  res.json({ message: "Place added successfully" });
}

export async function updatePlace(req, res) {
  const newData = {
    place: req.body.place,
    type: req.body.type,
    description: req.body.description,
    address: req.body.address,
    FK_city_id: req.body.FK_city_id,
  };

  await placesService.updatePlace(req.params.id, newData);
  res.json({ message: "Place updated successfully" });
}

export async function deletePlace(req, res) {
  await placesService.deletePlace(req.params.id);
  res.json({ message: "Place deleted successfully" });
}

export async function getPlacesByCity(req, res) {
  const places = await placesService.getPlacesByCity(req.params.cityId);
  res.json(places);
} 
