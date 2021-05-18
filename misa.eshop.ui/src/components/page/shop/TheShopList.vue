<template>
  <div class="shop-list">
    <!-- start content -->
    <div class="content">
      <div class="content-body" id="click-outside">
        <!-- start tool bar -->
        <div class="tool-bar">
          <div class="tool-bar-btn div-btn-add">
            <button
              class="t-btn btn-add click-outside"
              id="btn-add"
              @click="openModalCreateShop()"
            >
              <i class="t-icon t-icon-add"></i>
              <span>Thêm mới</span>
            </button>
          </div>
          <div
            class="tool-bar-btn div-btn-replication"
            title="Tính năng này đang được cập nhật"
          >
            <button
              class="t-btn btn-replication"
              id="btn-replication"
              @click="showAlertCopyObject()"
            >
              <i class="t-icon t-icon-replication"></i>
              <span>Nhân bản</span>
            </button>
          </div>
          <div class="tool-bar-btn div-btn-edit">
            <button
              class="t-btn btn-edit"
              id="btn-edit"
              @click="openEditDialog()"
            >
              <i class="t-icon t-icon-edit"></i>
              <span>Sửa</span>
            </button>
          </div>
          <div class="tool-bar-btn div-btn-delete">
            <button
              class="t-btn btn-delete"
              id="btn-delete"
              @click="openModalDeleteShop()"
            >
              <i class="t-icon t-icon-delete"></i>
              <span>Xóa</span>
            </button>
          </div>
          <div class="tool-bar-btn div-btn-load">
            <button class="t-btn btn-load" id="btn-load" @click="reLoadData()">
              <i class="t-icon t-icon-load"></i>
              <span>Nạp</span>
            </button>
          </div>
        </div>
        <!-- end tool bar -->

        <!-- start grid -->
        <div class="t-grid">
          <table
            id="tbl-list-store"
            cellspacing="0"
            cellpadding="0"
            width="100%"
          >
            <thead>
              <tr>
                <th class="col-15" fieldName="shopCode">
                  <div class="thead-text">Mã cửa hàng</div>
                  <div class="thead-filter">
                    <button class="t-btn condition">*</button>
                    <input
                      type="text"
                      class="t-input filter-text"
                      id="filter-shop-code"
                      v-model="filterDataTable.storeCode"
                    />
                  </div>
                </th>
                <th class="col-21" fieldName="shopName">
                  <div class="thead-text">Tên cửa hàng</div>
                  <div class="thead-filter">
                    <button class="t-btn condition">*</button>
                    <input
                      type="text"
                      class="t-input filter-text"
                      id="filter-shop-name"
                      v-model="filterDataTable.storeName"
                    />
                  </div>
                </th>
                <th class="col-42" fieldName="address">
                  <div class="thead-text">Địa chỉ</div>
                  <div class="thead-filter">
                    <button class="t-btn condition">*</button>
                    <input
                      type="text"
                      class="t-input filter-text"
                      id="filter-address"
                      v-model="filterDataTable.address"
                    />
                  </div>
                </th>
                <th class="col-10" fieldName="phoneNumber">
                  <div class="thead-text">Số điện thoại</div>
                  <div class="thead-filter">
                    <button class="t-btn condition">*</button>
                    <input
                      type="text"
                      class="t-input filter-text"
                      id="filter-phone-number"
                      v-model="filterDataTable.phoneNumber"
                    />
                  </div>
                </th>
                <th class="col-12" fieldName="status">
                  <div class="thead-text">Trạng thái</div>
                  <div class="thead-filter">
                    <select
                      type="text"
                      class="filter-select"
                      id="filter-status"
                      v-model="filterDataTable.status"
                    >
                      <option
                        v-for="option in storeStatus"
                        :key="option.value"
                        :value="option.value"
                      >
                        {{ option.statusName }}
                      </option>
                    </select>
                  </div>
                </th>
              </tr>
            </thead>

            <div v-show="!isLoaded" class="loading">
              <div class="loader"></div>
              <div class="text">Đang nạp dữ liệu</div>
            </div>
            <tbody v-if="shops && shops.length" class="tbl-scroll">
              <tr
                class="row-data"
                v-for="shop in shops"
                :key="shop.storeId"
                @click="clickRow(shop.storeId, shop)"
                @dblclick="openEditDialog(shop.storeId)"
                v-bind:class="isSelected(shop.storeId) ? 'selected' : ''"
              >
                <td class="col-15" :title="shop.storeCode">
                  {{ shop.storeCode }}
                </td>
                <td class="col-21" :title="shop.storeName">
                  {{ shop.storeName }}
                </td>
                <td class="col-42" :title="shop.address">{{ shop.address }}</td>
                <td class="col-10" :title="shop.phoneNumber">
                  {{ shop.phoneNumber | formatPhone() }}
                </td>
                <td class="col-12">{{ getStatusStoreName(shop.status) }}</td>
              </tr>
            </tbody>
          </table>
        </div>
        <!-- end grid -->
        <TheFooterStore />
      </div>
    </div>
    <!-- end content -->

    <ModalCreateShop
      ref="ModalCreate"
      :msg="formMode"
      :selectedShopId="selectedShopId"
      @showAlertDialog="showAlertDialog"
      :objectSelected="objectSelected"
    />

    <ModalDeletShop
      ref="ModalDelete"
      :selectedShopId="selectedShopId"
      @showAlertDelete="showAlertDelete"
    />
    <AlertModal
      v-show="showAlert"
      :visible="showAlert"
      :alertMessage="alertMessage"
    />
  </div>
</template>

<script>
import axios from "axios";
import TheFooterStore from "./TheFooterStore";
import ModalCreateShop from "../../modal/FunctionModal/ModalCreateShop";
import ModalDeletShop from "../../modal/FunctionModal/ModelDeleteShop";
import AlertModal from "../../modal/AlertModal";
export default {
  name: "Content",

  components: {
    ModalCreateShop,
    ModalDeletShop,
    TheFooterStore,
    AlertModal,
  },
  data() {
    return {
      objectSelected: null,
      formMode: "post",
      isLoaded: false,
      hasResult: false,
      canShowDialogDelete: false,
      shops: [],
      selectedShopId: null,
      storeStatus: [
        {
          statusName: "Tất cả",
          value: "",
        },
        {
          statusName: "Đang hoạt động",
          value: 0,
        },
        {
          statusName: "Ngưng hoạt động",
          value: 1,
        },
      ],
      filterDataTable: {
        storeCode: "",
        storeName: "",
        address: "",
        phoneNumber: "",
        status: 0,
        resetFilterStore() {
          this.storeCode = "";
          this.storeName = "";
          this.address = "";
          this.phoneNumber = "";
          this.status = 0;
        },
      },

      showAlert: false,
      alertMessage: "",
    };
  },

  created() {
    this.getStoreByFilter(this.filterDataTable);
    this.clickOutside();
  },

  /**
   * Theo dõi sự thay đổi của input filter.
   * Tự đông cập nhật,load dữ liệu khi input được thay đổi.
   * CreatedBy: vmquang 13/5/2021.
   */
  watch: {
    "filterDataTable.storeCode"() {
      this.getStoreByFilter(this.filterDataTable);
    },
    "filterDataTable.storeName"() {
      this.getStoreByFilter(this.filterDataTable);
    },
    "filterDataTable.address"() {
      this.getStoreByFilter(this.filterDataTable);
    },
    "filterDataTable.phoneNumber"() {
      this.getStoreByFilter(this.filterDataTable);
    },
    "filterDataTable.status"() {
      this.getStoreByFilter(this.filterDataTable);
    },
  },
  /**
   * Filter dữ liệu hiển thị.
   */
  filters: {
    /**
     * Filter số điện thoại, tách 3 số đầu.
     * CreatedBy: vmquang 13/5/2021.
     * Trả về số điện thoại đã tách 3 số đầu.
     * Trả về null nếu không có số điện thoại.
     */
    formatPhone(value) {
      if (value) {
        let result = value.replace(/(\d\d\d)(\d\d\d)(\d\d\d\d)/, "$1 $2$3");
        return result;
      }
      return null;
    },
  },
  methods: {
    /**
     * Lấy URL api filter dữ liệu.
     * CreatedBy: vmquang 13/5/2021.
     */
    getEndPointFiler(filter) {
      var paramCode = `storeCode=${filter.storeCode}`;
      var paramName = `storeName=${filter.storeName}`;
      var paramAddress = `address=${filter.address}`;
      var paramPhone = `phoneNumber=${filter.phoneNumber}`;
      var paramStatus = `status=${filter.status}`;
      var param = `?${paramCode}&${paramName}&${paramAddress}&${paramPhone}&${paramStatus}`;
      return `http://localhost:35480/api/v1/stores/filter${param}`;
      //`http://localhost:35480/api/v1/stores/filter?storeCode=${filter.storeCode}&storeName=${filter.storeName}&address=${filter.address}&phoneNumber=${filter.phoneNumber}&status=${filter.status}`;
    },

    /**
     * Hàm lấy dữ liệu theo API filter.
     * CreatedBy: vmquang 13/5/2021.
     */
    getStoreByFilter(filter) {
      var endpoint = this.getEndPointFiler(filter);

      axios
        .get(endpoint)
        .then((respone) => {
          this.shops = respone.data.data;
          if (this.shops.length == 0) {
            this.hasResult = true;
          } else {
            this.hasResult = false;
          }
        })
        .then(() => {
          this.isLoaded = true;
        })
        .catch((error) => console.log(error));
    },
    /**
     * Reload lại data, gọi đến hàm Filter dữ liệu với các param = empty.
     * CreatedBy: vmquang 13/5/2021.
     */
    reLoadData() {
      this.isLoaded = false;
      this.filterDataTable.resetFilterStore();
      this.getStoreByFilter(this.filterDataTable);
    },

    /**
     * 1 row có được chọn hay không.
     * trả về true/false.
     * CreatedBy: vmquang 13/5/2021.
     */
    isSelected(storeId) {
      if (this.selectedShopId == storeId) return true;
      return false;
    },

    /**
     * hàm xử 1 row được chọn.
     * gán Id của row được chọn, truyền vào props.
     * CreatedBy: vmquang 13/5/2021.
     */
    clickRow(storeId, shop) {
      this.selectedShopId = storeId;
      this.objectSelected = shop;
    },

    /**
     * Mở thông báo khi xóa 1 row.
     * Thông báo chọn row khi chưa được chọn.
     * Thông báo xóa row đang chọn.
     * CreatedBy: vmquang 13/5/2021.
     */
    openModalDeleteShop() {
      if (this.selectedShopId == null || this.selectedShopId == "") {
        this.openAlertModal("Vui lòng chọn bản ghi để xóa");
        return;
      }
      this.$refs.ModalDelete.show();
    },
    /**
     * đóng thông báo xóa dữ liệu.
     * CreatedBy: vmquang 13/5/2021.
     */
    closeDeletePopUp() {
      this.$refs.ModalDelete.hide();
    },
    /**
     * Hiển thị thông báo xóa.
     * CreatedBy: vmquang 13/5/2021.
     */
    showAlertDelete(alertMessage) {
      this.alertMessage = alertMessage;
      this.openAlertModal(this.alertMessage);
      this.reLoadData();
      this.closeDeletePopUp();
    },

    /**
     * Hiển thị modal Thêm mới cửa hàng.
     * CreatedBy: vmquang 13/5/2021.
     */
    openModalCreateShop() {
      this.checkQuang = true;
      this.$refs.ModalCreate.show();
      var input = this.$refs.ModalCreate;
      setTimeout(() => {
        input.$refs.storeCode.focus();
      }, 0);

      this.formMode = "post";
    },

    /**
     * đóng Modal thêm cửa hàng.
     * CreatedBy: vmquang 13/5/2021.
     */
    closeCreateDialogForm() {
      this.$refs.ModalCreate.hide();
    },

    // click outside
    clickOutside() {
      // window.addEventListener("click", function (e) {
      //   if (document.getElementById("click-outside").contains(e.target)) {
      //     console.log("inside");
      //   } else {
      //     // Clicked outside the box
      //     console.log("outside");
      //   }
      // });
    },

    /**
     * Sự kiện mở Modal để sửa
     * CreatedBy: vmquang 15.04.2021
     */
    openEditDialog() {
      if (this.selectedShopId == null || this.selectedShopId == "") {
        this.openAlertModal("Vui lòng chọn bản ghi để sửa");
        return;
      }
      this.formMode = "put";
      this.$refs.ModalCreate.show();
      // focus vào ô nhập liệu đầu tiên
      var input = this.$refs.ModalCreate;
      setTimeout(() => {
        input.$refs.storeCode.focus();
      }, 0);
    },

    /**
     * Hiển thị thông báo sao khi thêm/sửa.
     * CreatedBy: vmquang 13/5/2021.
     */
    openAlertModal(message) {
      this.showAlert = true;
      this.alertMessage = message;
      setTimeout(() => {
        this.showAlert = false;
      }, 4000);
    },

    /**
     * Lấy tên của trạng thái cửa hàng.
     * CreatedBy: vmquang 13/5/2021.
     */
    getStatusStoreName(value) {
      var status = String;
      if (value == 0) {
        status = "Đang hoạt động";
      } else if (value == 1) {
        status = "Ngưng hoạt động";
      } else {
        status = "";
      }
      return status;
    },

    showAlertDialog(alertMessage) {
      console.log(alertMessage);
      this.alertMessage = alertMessage;
      this.openAlertModal(this.alertMessage);
      this.reLoadData();
      this.closeCreateDialogForm();
    },
    showAlertCopyObject() {
      this.alertMessage = "Chức năng  đang hoàn thiện";
      this.openAlertModal(this.alertMessage);
    },
  },
};
</script>

<style  scoped>
@import "../../../styles/layout/toolbar.css";
@import "../../../styles/layout/content.css";
@import "../../../styles/base/animationLoading.css";
</style>