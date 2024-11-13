export class Score{

    constructor(
        public id : number,
        public pseudo : string | null,
        public date : string | null,
        public timeInSeconds : string | null,
        public scoreValue : string | null,
        public isPublic : boolean
    ){}

}