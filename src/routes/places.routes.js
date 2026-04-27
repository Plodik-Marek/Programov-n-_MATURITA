import expres from "express";

import * as placesController from "../controllers/places.controller.js";

const router = expres.Router();

router.get("/", placesController.getPlaces);
router.get("/:id", placesController.getPlace);
router.post("/", placesController.addPlace);
router.put("/:id", placesController.updatePlace);
router.delete("/:id", placesController.deletePlace);

router.get("/city/:cityId", placesController.getPlacesByCity);

export default router;
