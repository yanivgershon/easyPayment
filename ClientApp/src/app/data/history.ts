import { User } from "./user";

export class HistoryData {

    /**
     *
     */
    constructor(_date,_amount,_numPayments,_paymentType,_user) {
      
        this.date=_date;
        this.amount=_amount;
        this.numPayments=_numPayments;
        this.paymentType=_paymentType;
        this.user=_user;
    }

    date;
    amount;
    numPayments;
    paymentType
    user:User;

}
