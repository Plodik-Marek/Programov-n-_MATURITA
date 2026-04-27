import * as reviewsService from "../services/raitings.services.js";

export async function getRaitings(req, res) {
  const raitings = await reviewsService.getRaitings();
  res.json(raitings);
}

export async function getRaiting(req, res) {
  const raiting = await reviewsService.getRaiting(req.params.id);
  res.json(raiting);
}

export async function addRaiting(req, res) {
  const newRaiting = {
    FK_place_id: req.body.FK_place_id,
    raiting: req.body.raiting,
  };

  await reviewsService.addRaiting(newRaiting);
  res.json({ message: "Raiting added successfully" });
}

export async function updateRaiting(req, res) {
  const updatedRaiting = {
    FK_place_id: req.body.FK_place_id,
    raiting: req.body.raiting,
  };

  await reviewsService.updateRaiting(req.params.id, updatedRaiting);
  res.json({ message: "Raiting updated successfully" });
}

export async function deleteRaiting(req, res) {
  await reviewsService.deleteRaiting(req.params.id);
  res.json({ message: "Raiting deleted successfully" });
}

export async function getRaitingsByPlace(req, res) {
  const raitings = await reviewsService.getRaitingsByPlace(req.params.placeId);
  res.json(raitings);
}

export async function getAverageRaitingByPlace(req, res) {
  const average = await reviewsService.getAverageRaitingByPlace(req.params.placeId);
  res.json(average);
}
