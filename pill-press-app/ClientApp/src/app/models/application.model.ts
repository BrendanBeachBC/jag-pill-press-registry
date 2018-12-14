import { DynamicsAccount } from './dynamics-account.model';
import { AdoxioLicense } from './adoxio-license.model';
import { Invoice } from './invoice.model';
import { DynamicsContact } from './dynamics-contact.model';
import { BusinessContact } from './business-contact.model';
import { CustomAddress } from './custom-address.model';
import { EquipmentLocation } from './equipment-location.model';

export class Application {
  id: string;
  statuscode: string;
  title: string;
  applicationtype: string;
  submittedDate: Date;
  additionalbusinessinformationaboutseller: string;
  borrowrentleaseequipment: boolean;
  currentlyownusepossessequipment: boolean;
  declarationofcorrectinformation: boolean;
  delbusinessname: string;
  drugestablishmentlicence: boolean;
  drugestablishmentlicenceexpirydate: Date;
  drugestablishmentlicencenumber: string;
  foippaconsent: boolean;
  foodanddrugact: boolean;
  intendonrentingleasingtoothers: boolean;
  intendonsellingequipmenttoothers: boolean;
  intendtopurchaseequipment: boolean;
  intendtoselldiemouldorpunch: boolean;
  intendtosellencapsulator: boolean;
  intendtosellother: string;
  intendtosellothercheck: boolean;
  intendtosellpharmaceuticalmixerorblender: boolean;
  intendtosellpillpress: boolean;
  kindsofproductsdrugs: boolean;
  kindsofproductsnaturalhealthproducts: boolean;
  kindsofproductsother: string;
  kindsofproductsothercheck: string;
  legislativeauthorityother: string;
  legislativeauthorityothercheck: string;
  mainbusinessfocus: string;
  manufacturerofcontrolledequipment: boolean;
  manufacturingprocessdescription: string;
  onetimesellerofowncontrolledequipment: boolean;
  otherlicence: string;
  otherlicencebusinessname: string;
  otherlicencecheck: string;
  otherlicenceexpirydate: Date;
  otherlicencenumber: string;
  ownintendtoownequipmentforbusinessuse: boolean;
  ownusepossesstoproduceaproduct: boolean;
  producingownproduct: boolean;
  providingmanufacturingtoothers: boolean;
  retailerofcontrolledequipment: boolean;
  sellequipment: boolean;
  sitelicence: boolean;
  sitelicencebusinessname: string;
  sitelicenceexpirydate: Date;
  sitelicencenumber: string;
  typeofsellerother: string;
  typeofsellerothercheck: boolean;

  // EquipmentFields
  addressPersonBusinessThatBuiltEquipment: string;
  alternativeOwnershipArrangement: boolean;
  areYouARegisteredSeller: boolean;
  bcSellersContactEmail: string;
  bcSellersContactPhoneNumber: string;
  bcSellersRegistrationNumber: string;
  confirmationOfAuthorizedUse: boolean;
  customBuiltSerialNumber: string;
  dateOfPurchaseFromBcSeller: Date;
  dateOfPurchaseFromImporter: Date;
  dateOfPurchaseFromOutsideBcSeller: Date;
  declarationOfCorrectInformation: boolean;
  detailsOfAssemblyForOtherBusinesses: string;
  detailsOfHowEquipmentCameIntoPossession: string;
  doYouAssembleForOtherBusinesses: boolean;
  emailOfBusinessThatHasRentedOrLeased: string;
  emailOfTheBusinessThatHasGivenOrLoaned: string;
  encapsulatorMaxCapacity: string;
  equipmentMake: string;
  equipmentModel: string;
  equipmentType: string;
  equipmentTypeOther: string;
  explanationOfEquipmentuse: string;
  giveNorLoanedToMe: boolean;
  howCameIntoPossessionOther: string;
  howCameIntoPossessionOtherCheck: boolean;
  howEquipmentBuiltDescription: string;
  howWasEquipmentBuilt: string;
  howWasEquipmentBuiltOther: string;
  howWasEquipmentBuiltOtherCheck: boolean;
  iAssembledItMyself: boolean;
  importedToBcByAThirdParty: boolean;
  importersRegistrationNumber: string;
  kindOfAlternateOwnershipOther: string;
  kindOfAlternateOwnershipOtherCheck: boolean;
  levelOfEquipmentAutomation: string;
  nameOfBcSeller: string;
  nameOfBusinessThatHasGivenOrLoaned: string;
  NameOfBusinessThatHasRentedOrLeased: string;
  nameOfImporter: string;
  nameOfManufacturer: string;
  nameOfOriginatingSeller: string;
  originatingSellersLocation: string;
  outsideBcSellersLocation: string;
  outsideBcSellersName: string;
  ownedBeforeJan2019: boolean;
  personBusinessThatBuiltEquipment: string;
  phoneofbusinessthathasgivenorloaned: string;
  phoneOfBusinessThatHasRentedOrLeased: string;
  pillpressEncapsulatorsize: string;
  pillpressEncapsulatorSizeOther: string;
  pillpressEncapsulatorSizeOtherCheck: boolean;
  pillpressmaxcapacity: string;
  possessUntilICanSell: boolean;
  purchasedFromBcSeller: boolean;
  purchasedFromSellerOutsideOfBc: boolean;
  rentingOrLeasingFromAnotherBusiness: boolean;
  serialNumber: string;
  serialNumberForCustomBuilt: boolean;
  serialNumberKeyPartDescription: string;
  usingToManufactureAProduct: boolean;
  whenDidYouAssembleEquipment: Date;
  whereDidYouObtainParts: string;
  whyHaveYouAcceptedOrBorrowed: string;
  whyHaveYouRentedOrLeased: string;

  // related entities
  addressOfBusinessThatHasRentedorLeased: CustomAddress;
  addressofBusinessthathasGivenorLoaned: CustomAddress;
  addressofPersonBusiness: CustomAddress;
  applicant: Account;
  bcSellersAddress: CustomAddress;
  businessContacts: BusinessContact[];
  customProducts: CustomProduct[];
  importersAddress: CustomAddress;
  outsideBcSellersAddress: CustomAddress;
  OriginatingSellersAddress: CustomAddress;
  equipmentLocation: EquipmentLocation;
}
