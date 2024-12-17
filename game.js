/**
* Implementazione del videogioco Pong.
* @author Siarou Aliaksandr
* @version 1.0
*/


const STAGE_ID = "stage";
const STAGE_X = 10;
const STAGE_Y = 40;
const STAGE_WIDTH = 640;
const STAGE_HEIGHT = 400;
const BACKGROUND = "assets/background.png";
const PLAYER1 = "assets/player1.png";
const PLAYER2 = "assets/player2.png";
const BALL = "assets/ball.png";
const HIT = "assets/hit.wav";
const BG_SONG = "assets/bgsong.mp3";


//---------------------------------------------------------
/**
* Classe per la gesitione di uno sfondo
*
*/
class Background extends Sprite {
  /**
  * Crea un nuovo oggetto Background.
  * @param {string} path - percorso della risorsa
  * @param {number} width - larghezza dello sfondo
  * @param {number} height - Altezza dello sfondo
  */
  constructor(path, width, height) {
    super(path, width, height);

  }
}
//---------------------------------------------------------
class Game {
  constructor() {
    this.background = new Background(BACKGROUND, STAGE_WIDTH, STAGE_HEIGHT);
  }

  update() {

  }
  draw() {
    
  }
}
