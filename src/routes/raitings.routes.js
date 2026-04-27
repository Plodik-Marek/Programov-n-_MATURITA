import expres from "express";

import * as raitingsController from "../controllers/raitings.controller.js";

const router = expres.Router();

router.get("/", raitingsController.getRaitings);
router.get("/:id", raitingsController.getRaiting);
router.post("/", raitingsController.addRaiting);
router.put("/:id", raitingsController.updateRaiting);   
router.delete("/:id", raitingsController.deleteRaiting);

router.get("/place/:placeId", raitingsController.getRaitingsByPlace);
router.get("/place/:placeId/average", raitingsController.getAverageRaitingByPlace);

export default router;
